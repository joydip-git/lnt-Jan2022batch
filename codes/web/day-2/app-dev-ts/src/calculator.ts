type calculateFnType = (x: number, y: number) => number
function calculate(fnRef: calculateFnType, a: number, b: number): void {
   var res = fnRef(a, b)
   console.log(res)
}