/**
 * Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:
 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 */


var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";


tags(text);


function tags(param) {
    var i,
        inMixCase = false,
        inUpCase = false,
        counterOfTags = 0,
        inLowCase = false,
        inCase = false,
        result = "";


    for (i = 0; i <= param.length - 1; i++) {

        if (param[i] == "<") {
            inCase = true;
            counterOfTags++;
        }
        if (counterOfTags % 2 == 0) {
            inUpCase = false;
            inMixCase = false;
            inLowCase = false;
        }

        if (param[i] == ">") {
            inCase = false;
            continue;
        }
        if (inCase == true) {
            if (param[i + 1] == "m") {
                inMixCase = true;
            }
            else if (param[i + 1] == "u") {
                inUpCase = true;
            }
            else if (param[i + 1] == "l") {
                inLowCase == true;
            }
            continue;
        }

        if (inUpCase) {
            result += param[i].toUpperCase();
            continue;
        }
        if (inLowCase) {
            result += param[i].toLowerCase();
            continue;
        }
        if (inMixCase) {
            if ((Math.random() + 1) > 1.5) {
                result += param[i].toUpperCase();
            }
            else {
                result += param[i];
            }
            continue;
        }

        if (inCase == false) {
            result += param[i];
            continue;
        }
    }
    return console.log(result);
}


