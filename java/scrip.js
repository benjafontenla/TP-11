//1er PreEntrega

class camisetas {
    constructor(equipo, modelo, numeroDeArticulo) {
        this.equipo = equipo;
        this.modelo = modelo;
        this.numeroDeArticulo = numeroDeArticulo;
    }
    //Function
    ver() {
        alert('Tenemos disponible el modelo ' + this.modelo + ' del equipo de ' + this.equipo + '.' + ' Podes encontrar este producto en la seccion "Camisetas."');
    }
}

const camiseta1 = new camisetas('ferro', 'titular', 01);
const camiseta2 = new camisetas('comunicaciones', 'alternativo', 02);
const camiseta3 = new camisetas('allboys', 'alternativo', 03);
const camiseta4 = new camisetas('argentinosjuniors', 'titular', 04);
const camiseta5 = new camisetas('flandria', 'titular', 05)

let busquedaCamiseta = false;

for (let i = 0; i < 3; i++) {
    let ingresar = prompt('Ingresa el nombre del club de la camiseta que desea buscar. (Sin mayusculas ni espacios)')
    if (ingresar == camiseta2.equipo) {
        camiseta2.ver();
        busquedaCamiseta = true;
        break;
    } else if (ingresar == camiseta1.equipo) {
        camiseta1.ver();
        busquedaCamiseta = true;
        break;
    } else if (ingresar == camiseta3.equipo) {
        camiseta3.ver();
        busquedaCamiseta = true;
        break;
    } else if (ingresar == camiseta4.equipo) {
        camiseta4.ver();
        busquedaCamiseta = true;
        break;
    } else if (ingresar == camiseta5.equipo) {
        camiseta5.ver();
        busquedaCamiseta = true;
        break;
    } else {
        alert('Lo sentimos, la camiseta de ' + ingresar + ' no esta disponible.');
    }
}