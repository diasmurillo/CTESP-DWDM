const botao = document.querySelector('button')
const cor = document.getElementById('color')

function gerarCorHexa (){
    let digitos = "0123456789ABCDEF"
    let hexaSimbolo = '#'

    for (let i = 0; i < 6; i++){

        let indiceAleatorio = Math.floor(Math.random()*16)
        hexaSimbolo+=digitos[indiceAleatorio]

    }
    
    return hexaSimbolo

}

botao.addEventListener('click', function(){
    let corRandom = gerarCorHexa();

    cor.textContent = corRandom
    document.body.style.backgroundColor = corRandom
})