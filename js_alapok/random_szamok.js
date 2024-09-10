
function veletlenszam(min,max){
    return Math.floor(Math.random()*(max-min))+min;
}

//let randomszam=Math.floor(Math.random()*(100-10))+10;
let randomszam=veletlenszam(20,100);



let randomh1=document.createElement('h1');

randomh1.textContent=randomszam;

root.appendChild(randomh1);
Math.r

//Feladat
//Hozzon létre két listát! Az egyikben 6 db vezetéknév,
// a másikban 6db keresztnév legyen! Írjon kódot, amely kigenerál 15 nevet véletlenszerűen
//és egy listában megjeleníti a weboldalon!