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
// Urlap adatok
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