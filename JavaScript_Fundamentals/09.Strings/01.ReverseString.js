/**
 *Write a JavaScript function that reverses a string and returns it.
 */


var a = "sample";


reversedString(a);


function reversedString(param) {
    var i,
        result = "",
        toAdd;

    for (i = param.length-1; i >= 0; i--) {
        toAdd = param[i];
        result += toAdd;
    }
    return console.log(result);
}
