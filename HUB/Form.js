function ellen(){
// Urlap adatok
var feszultseg=document.getElementById('fesz').value;
var aramerosseg=document.getElementById('aram').value;
// Szamitas
var ellenallas=feszultseg/aramerosseg;
// Megjelenites
document.getElementById('fesze').innerHTML = feszultseg;
document.getElementById('arame').innerHTML = aramerosseg;
document.getElementById('ellene').innerHTML = ellenallas;
}
function szamol(){
var hossz=document.getElementById('hossz').value;
var rovid=document.getElementById('rovid').value;
// Szamitas
var terulet=hossz*rovid
var kerulet=2*(hossz*1+rovid*1);
// Megjelenites
document.getElementById('hossze').innerHTML = hossz;
document.getElementById('rovide').innerHTML = rovid;
document.getElementById('terulete').innerHTML = terulet;
document.getElementById('kerulete').innerHTML = kerulet;
}
function ar(){
const palack=document.getElementById('palack').value;
const rekesz=document.getElementById('rekesz').value;
const asvanyviz=document.getElementById('asvanyviz').value;
// Szamitasok
let ar = (rekesz*6+palack*1)*asvanyviz;
// Megjelenites
document.getElementById('palacke').innerHTML = palack;
document.getElementById('rekesze').innerHTML = rekesz;
document.getElementById('are').innerHTML = ar;
}
function szamolas(){
var aoldal=document.getElementById('a').value;
var boldal=document.getElementById('b').value;

var kerulet=(aoldal*1+boldal*1)*2;
var terulet=aoldal*boldal;

document.getElementById('ae').innerHTML = aoldal;
document.getElementById('be').innerHTML = boldal;
document.getElementById('kere').innerHTML = 0;
if (document.getElementById('ker').checked)
document.getElementById('kere').innerHTML = kerulet;
document.getElementById('tere').innerHTML = 0;
if (document.getElementById('ter').checked)
document.getElementById('tere').innerHTML = terulet;
}