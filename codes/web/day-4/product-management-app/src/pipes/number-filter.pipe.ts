import { isDevMode, Pipe } from "@angular/core";

const isEven = function (num: number) {
    return num % 2 == 0
}
const isOdd = function (num: number) {
    return num % 2 != 0
}

@Pipe({ name: 'numberfilter' })
export class NumberFilterPipe {
    transform(numberArray: number[], ...args: number[]): number[] {

        let filteredArray: number[] = []
        switch (args[0]) {
            case 1:
                filteredArray = numberArray.filter(isEven)
                break;

            case 2:
                filteredArray = numberArray.filter(isOdd)
                break;

            default:
                break;
        }
        return filteredArray
    }
}

