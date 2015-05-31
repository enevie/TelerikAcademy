/**
 * Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */


var arr = [3, 6, 9, 1, 2, 20, 36, 222, 785, 111, 53, 23];


selectionSort(arr);

for (var b in arr)
{
    console.log(arr[b]);
}

function selectionSort(sortMe) {
    var i, j, tmp, tmp2;
    for (i = 0; i < sortMe.length - 1; i++) {
        tmp = i;
        for (j = i + 1; j < sortMe.length; j++) {
            if (sortMe[j] < sortMe[tmp]) {
                tmp = j;
            }
        }
        if (tmp != i) {
            tmp2 = sortMe[tmp];
            sortMe[tmp] = sortMe[i];
            sortMe[i] = tmp2;
        }
    }
    return sortMe;
}
