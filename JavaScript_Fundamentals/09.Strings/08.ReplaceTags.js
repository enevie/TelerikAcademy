/**
 * Problem 8. Replace tags

 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */


var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';


replaceTags(text);

function replaceTags(param)
{
    var currRes = param.replace(/a href/g, "URL");
    var res =  currRes.replace(/\/a/g, "/URL")
    return console.log(res);
}

