import React from "react";
import { HostObjectsAsyncRoot } from "./types/webview2";

/**
  * Known supported data types:
  * 
  * number, string, array, objects (as a JSON string)
  * 
  * Only handle null & undefined values from TypeScript.
 */
type CustomHostObjects = HostObjectsAsyncRoot & {
    nativeClass: {
        Show: () => void;

        Add: (a: number, b: number) => Promise<number>;
        AddByObject: (json_str: string) => Promise<number>;
    }
}

const { nativeClass } = window.chrome.webview.hostObjects as CustomHostObjects;

/** liaison function */
async function addByObject(params: {a: number, b: number}) {
    return nativeClass.AddByObject(JSON.stringify(params));
}


export default function AddComponent() {
    const [left, setLeft] = React.useState(1);
    const [right, setRight] = React.useState(2);

    const [sum, setSum] = React.useState(0);

    return <>
        <p>
            a = 
            <input type="number"
                value={left}
                onChange={e => setLeft(Number(e.target.value))} />
        </p>

        <p>
            b =
            <input type="number"
                value={right}
                onChange={e => setRight(Number(e.target.value))} />
        </p>

        <p>
            <button onClick={async () =>
                setSum(await nativeClass.Add(left, right))
            }>Sum</button>

            <button onClick={async () =>
                setSum(await addByObject({ a: left, b: right }))
            }>
                Sum (by object parameter)
            </button>
        </p>

        <p>a + b = {sum}</p>
    </>
}

