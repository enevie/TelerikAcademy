/**
 * Problem 2. Correct brackets

 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 */


var expression = "((a+b)/5-d)";
var expressionB = ")(a+b))";

checkForBrackets(expression);
checkForBrackets(expressionB)

function checkForBrackets(param) {
    var i,
        numberOfBrackets = 0,
        inBracket = false,
        openingBrecket = 0,
        closingBrecket = 0;

    for (i = 0; i < param.length; i++) {
        if (param[i] == "(") {
            inBracket = true;
            openingBrecket++;
            numberOfBrackets++;
        }
        else if (param[i] == ")") {
            inBracket = false;
            closingBrecket++;
            numberOfBrackets++;
        }

    }
    if (inBracket == true || numberOfBrackets % 2 != 0 || openingBrecket != closingBrecket) {
        return console.log("The expression is incorrect!");
    }
    else {
        return console.log("The expression is correct!");
    }
}