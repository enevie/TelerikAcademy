/**
 *Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */

var sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

findSeq(sequence);

function findSeq(arr) {
    var indexOfEqualElements = 1;
    var maxSeq = 0;
    var theSeqDigit = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] == arr[i + 1]) {
            indexOfEqualElements++;
            if (indexOfEqualElements > maxSeq) {
                maxSeq = indexOfEqualElements;
                theSeqDigit = arr[i];
            }
        } else {
            indexOfEqualElements = 1;
        }
    }

    for (var m = 0; m < maxSeq; m++) {
        console.log(theSeqDigit);
    }
}
