/**
 * Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */


var text = "test1@abv.bg ala baba georgi@google.com xxx tedi@rara.com";

extarctMails(text);

function extarctMails(param) {
    var i,
        inMail = false,
        currMail = "",
        mails = [];

    for (i = 0; i <= param.length; i++) {
        if (param[i] == "@") {
            inMail = true;
            continue;
        }
        if (param[i] == " " || i == param.length) {
            inMail = false;
            if (currMail == "") {
                continue;
            }
            mails.push(currMail);
            currMail = "";
            continue;
        }
        if (inMail) {
            currMail += param[i];
        }
    }
    return console.log(mails);
}
