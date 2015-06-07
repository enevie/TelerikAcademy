/**
 * Problem 7. Parse URL

 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 */

var url = "https://telerikacademy.com/Courses/Courses/Details/239";

extractURL(url);

function extractURL(param) {
    var i,
        element = {protocol: "", server: "", resource: ""},
        currProtocol = "",
        counterSlash = 0,
        inProtocol = true,
        inServer = false,
        inResource = false,
        currServer = "",
        currResource = "";


    for (i = 0; i < param.length; i++) {
        if (param[i] == ":") {
            inServer = true;
            continue;
        }

        if (param[i] == "/") {
            counterSlash++;
            if (counterSlash == 3) {
                inProtocol = false;
            }
            if (inProtocol) {
                continue;
            }

            if (counterSlash >= 3) {
                inResource = true;
                inServer = false;
            }
        }

        if (inServer) {
            currServer += param[i];
        }
        else if (inResource) {
            currResource += param[i];
        }
        else if (inProtocol) {
            currProtocol += param[i];
        }
    }

    element.protocol = currProtocol;
    element.resource = currResource;
    element.server = currServer;

    return console.log(element);
}