//oque sao vetores e arrays

//como declarar
let array = ["string", 1, true]

//pode guardar varios tipos de dados
let arrays = ["string", 1, true, ['array1'], ['array2']];

//forEach - itera um array
array.forEach(function(item, index){item, index});

//push - add item no final do array
array.push('novo item');

//pop - remove item no final do array
array.pop();

//shift - remove item no inicio do array
array.shift();

//unshift - add item no inicio do array
array.unshift('novo item inicio');

//indexOf - retorna o indice de um valor

console.log(array.indexOf());

//splice - remove ou substitui um item pelo indice
array.splice(0,3);

//slice - retorna uma parte de um
let novoArray = array.slice(0,3)


//objetos
let object = {}

//para acessar algo dentro do objeto
//  object.oque tem dentro do objeto;

