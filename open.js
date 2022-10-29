document.querySelector("h1").style.color='red';
document.querySelector("h2").style.color='green';

var n = prompt('enter your name: ');
var size = n.length;
var reversedName = ''
for( let i = size-1 ; i >= 0 ; i-- ){
    reversedName+= n[i];
}
alert(reversedName)