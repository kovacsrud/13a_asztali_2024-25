let root=document.getElementById('root');

let ul=document.createElement('ul');

let li_1=document.createElement('li');
let li_2=document.createElement('li');
let li_3=document.createElement('li');

li_1.textContent="egy";
li_2.textContent="kettő";
li_3.textContent="három";

ul.append(li_1);
ul.append(li_2);
ul.append(li_3);

//Hozzunk létre egy címsor 2 elemet, adjunk neki egy szöveget, pl. felsorolás
//adjuk hozzá a root elemhez

let h2=document.createElement('h2');
h2.textContent="Felsorolás";

root.appendChild(h2);
root.appendChild(ul);