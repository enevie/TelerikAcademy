/**
 * Problem 6. Extract text from HTML

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 */

var test = "<html> <head> <title>Sample site</title> </head> <body> <div>text <div>more text</div>and more... </div>in body </body> </html>";


extractText(test);

function extractText(param) {
    var i,
        result = "",
        inTag = false;

    for (i = 0; i <= param.length - 1; i++) {
        if (param[i] == "<") {
            inTag = true;
            continue;
        }
        if (param[i] == ">") {
            inTag = false;
            continue;
        }
        if (inTag == false) {
            result += param[i];
        }
    }

    return console.log(result);

}