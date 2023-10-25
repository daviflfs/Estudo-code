function calculadora() {
    const operacao = promt('escolha uma operação:\n 1 -soma\n 2 - substração\n 3 - multiplicação\n 4 - divisão\n 5 -divisão inteira\n 6 - potenciação');
}
if (!operacao || operacao >= 7) {
    console.log(' erro - opção invalidade digite algo valido');
    calculadora();
} else {
    let n1 = Number(promt('insira primeiro valor'))
    let n2 = Number(promt('insira segundo valor'))
    let resultado;

    if (!n1 || !n2) {
        alert('eero - parametros invalidos')
        calculadora()
    } else {
        function soma() {
            resultado = n1 + n2;
            alert(`${n1} + ${n2} = ${resultado}}`)
            novaOperacao()
        }
        function substracao() {
            resultado = n1 - n2;
            alert(`${n1} - ${n2} = ${resultado}}`)
            novaOperacao()
        }

        function multiplicacao() {
            resultado = n1 * n2;
            alert(`${n1} * ${n2} = ${resultado}}`)
            novaOperacao()
        }

        function divisao() {
            resultado = n1 / n2;
            alert(`${n1} / ${n2} = ${resultado}}`)
            novaOperacao()
        }

        function divisaoInteira() {
            resultado = n1 % n2;
            alert(`o resto da divisao entre ${n1} e ${n2} é igual a ${resultado}}`)
            novaOperacao()

            function potenciacao() {
                resultado = n1 ** n2;
                alert(`${n1} elevado ${n2} é igual a ${resultado}}`)
                novaOperacao()
            }

            function novaOperacao() {
                let opcao = promt('Deseja realizar outra operação\n 1- Sim!\n 2- Não')
                if (opcao == 1) {
                    calculadora();
                } else if (opcao == 2) {
                    alert('ate mais')
                } else {
                    alert('digite uma opcao valida')
                }
            }
        }
    }

    // if(operacao == 1){
    //     soma()
    // }else if(operacao ==2){
    //     substracao()
    // }else if(operacao == 3){
    //     multiplicacao()
    // }else if(operacao == 4){
    //     divisao()
    // }else if(operacao == 5){
    //     divisaoInteira()
    // }else if(operacao == 6){
    //     potenciacao()
    // }

    switch (operacao) {
        case 1:
            soma();
            break;
        case 2:
            substracao();
            break;
        case 3:
            multiplicacao();
            break;
        case 4:
            divisao();
            break;
        case 5:
            divisaoInteira();
            break;
        case 6:
            potenciacao();
            break;

    }
}
calculadora();