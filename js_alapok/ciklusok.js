let nevek=["Elek","Ubul","Ágnes","Zénó","Ella"];

let nevcimsor=document.createElement('h2');
nevcimsor.textContent="Névsor";
root.appendChild(nevcimsor);

let lista=document.createElement('ul');

for(let i=0;i<nevek.length;i++){
    let listaElem=document.createElement('li');
    listaElem.textContent=nevek[i];
    lista.appendChild(listaElem);
}



//while ciklus
let szamlalo=0;
while(szamlalo<nevek.length){
    let listaElem=document.createElement('li');
    listaElem.textContent=nevek[szamlalo];
    lista.appendChild(listaElem);
    console.log(szamlalo);
    szamlalo++;
    
}

root.appendChild(lista);

//Mint a C# foreach ciklusa
for(let i of nevek){
    console.log(i);
}