/**
 * Problem 2. Numbers not divisible
 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */

printNumbers(70);

function printNumbers(param) {

    var arrayX=[];

    for (var i = 0; i <= param; i++) {
        if ((i % 3 != 0) || (i % 7 != 0)) {
            console.log(i);
        }
        else{
            console.log("skipped: " + i);
        }
    }
}