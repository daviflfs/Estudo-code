//estruturas condicionais 

var jogador1 = 0
var jogador2 = 0;
var placar;

//if ternario
jogador1 != -1 && jogador2 != -1 ? console.log('jogadores sao validos'):
console.log('jogadores Invalidos');

//usando if

    if (jogador1 > 0 && jogador2 == 0) {
        console.log('jogador 1 marcou ponto');
        placar = jogador1 > jogador2;
    } 
    //usando else if
    else if (jogador2 > 0 && jogador1 == 0) {
        console.log('jogador 2 marcou ponto')
        placar = jogador2 > jogador1;
    } 
    //usando else
    else {
        console.log('ninguem marcou ponto');
    }

    //usando switch

    switch (placar){
        case placar = jogador1 > jogador2:
            console.log('jogador 1 ganhou!');
            break;

        case placar = jogador2 > jogador1:
            console.log('jogador 2 ganhou!');
            break;
        
        default:
            console,log('empate!')
        
    }

//estruturas de repetição

let array = ['valor1','valor2','valor3','valor4','valor5',]

let object = {propriedade:'valor',propriedade2:'valor2',propriedade3:'valor3',}

//for - executa uma instrução ate que ela seja falsa
for(let indice = 0; indice < array.length; indice++);

//for / in - executa repetição a partir de uma propriedade
for(let i in array){
    console.log(i)
}

//com object
for(i in object){
    console.log(i)
}

//for / or - executa repetição a partir de valor
//com array
for(i of array){
    console.log(i)
}

//com object - n funciona
for(i of object.propriedade1){
    console.log(i)
}

//while / do
var a = 0;

while (a < 10){
    a++;
    console.log(a);
}

do{
    a++;
    console.log(a);
}while(a < 10)
