let ingresar = false;

let nombreUsuario = prompt('Ingresa tu nombre')
alert('Bienvenido/a ' + nombreUsuario)

let descuento = 'himalayasale';
for (let i = 0; i < 3; i++) {
    let codigo = prompt('Ingresa tu codigo de descuento');

    if (descuento == codigo) {
        alert('Felicitaciones ' + nombreUsuario + ',' + ' tu descuento de $1000 ha sido aplicado correctamente');
        ingresar = true;
        break;
    } else {
        alert('El codigo es incorrecto')
    }
}

//Calcula de 2 productos + el iva - descuento 
if (ingresar) {
    const suma = (numeroA, numeroB, numeroC, numeroD) => numeroA + numeroB + numeroC + numeroD
    const resta = (numeroA, numeroB) => numeroA - numeroB

    const impuestos = (x) => x * 0.21
    const impuestosB = (x) => x * 0.21


    let precioProductoA = 5000
    let precioProductoB = 2500
    let descuentoEspecial = 1000



    let nuevoPrecio = resta(suma(precioProductoA, precioProductoB, impuestos(precioProductoA), impuestosB(precioProductoB)), descuentoEspecial)


    alert('El producto selecionado te queda en un costo final de $' + nuevoPrecio + '.' + ' (Descuento e impuestos aplicados)')
    console.log(nuevoPrecio)
}