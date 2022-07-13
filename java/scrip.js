
let descuento = 'himalayasale';
for (let i = 0; i < 3; i++) {
    let codigo = prompt('ingresa tu codigo de descuento');

    if (descuento == codigo) { 
        alert('Tienes hasta 50% off en productos selecionados');
        break;
    }

}