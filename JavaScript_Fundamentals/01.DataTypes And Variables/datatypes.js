var int = 3;
var float = 4.5;
var string = 'abc';
var array = [3,5,2];
var object = {course: 'js'};
var nullable = null;
var boolean = true;
var undefindedValue = undefined;

var variables = [int, float, string,array,object,nullable,undefindedValue];

for(var variable in variables)
{
    console.log(getTypeString(variables[variable]));
}

var quotedString =  "'How you doin'?', Joey said'.";
console.log(quotedString);

function getTypeString(obj)
{
    var result = obj;
    result += ' is ' + typeof obj;
    return result;
}