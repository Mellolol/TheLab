var name = prompt("Mi a keresztneved");
document.write(name.charAt(0).toUpperCase(),name.substr(1),'<br>');

var name = prompt("Mi a teljes neved");
//A keresztnevvel koszon
var i = name.lastIndexOf(' ')+1;
document.write("Szia ",name.substr(i),"!<br>");

//Kiirja a vezeteknevet nagybetuvel
document.write(name.substr(0,i).toUpperCase(),"<br>");

//A vezeteknev es a keresztnev is nagybetuvel fog kezdodni
document.write(name.charAt(0).toUpperCase(),name.substr(1,i-1),name.charAt(i).toUpperCase(),name.substr(i+1),"<br>");

// Minden masodik betu nagy lesz
for(j=0;j<=name.length-1;j++)
{
  if(j%2==0){
    document.write(name.charAt(j).toUpperCase());
  }
  else{
    document.write(name.charAt(j));
  }
}
document.write("<br>");

//Kiijra az adott szovegben szerepel-e
if((name.indexOf('t'))>=0)
{
  document.write("van benne t<br>");
}
else{
  document.write("NINCS BENNE T");
}

//Kiirja a vezetekneved visszafele
var l = name.lastIndexOf(' ')+1;
for(j=l-1;j>=0;j--)
{
  document.write(name.charAt(j).toUpperCase());
}
document.write("<br>");
//Kiirja a keresztneved visszafele
for(j=name.length-1;j>=l;j--)
{
    document.write(name.charAt(j).toUpperCase());
}
document.write("<br>");
//Kiirja a teljes nevet, minden betu utana ' '
for(j=0;j<name.length;j++)
{
    document.write(name.charAt(j).toUpperCase());
    document.write(" ");
}
document.write("<br>");
var betu = prompt("Mit akarsz cserelni: ");
var betu2 = prompt("Mire akarod csereldni: ");
for(j=0;j<name.length;j++)
{
if(name.chaAt(j)==betu) {document.write(betu2.toUpperCase())}
else{document.write(name.charAt(j).toUpperCase())}
}
for(j=0;j<name.length;j++)
{
    document.write(name.charAt(j).toUpperCase());
}
