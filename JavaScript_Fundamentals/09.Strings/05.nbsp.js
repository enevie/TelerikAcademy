/**
 *Problem 5. nbsp

 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

var text = "This is a simple test!";

replaceWhiteSpace(text);

function replaceWhiteSpace(param)
{
    var res = param.replace(/ /g, "nbsp");
    return console.log(res);
}