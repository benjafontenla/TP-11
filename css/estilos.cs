.nav {
  /*background-color: black;*/
  display: grid;
  grid-template-columns: repeat(8, 1fr);
  align-items: center;
  color: rgb(243, 235, 235);
  background-image: linear-gradient(to right, rgb(252, 252, 255), rgb(15, 44, 68));
}
.nav .logo {
  width: 60px;
  height: 60px;
  grid-column: 2/3;
  transform: translate(-150px);
  /*transform: scale(1,1);*/
  /*transform: skew(20deg,10deg);*/
  /*transform: rotate(80deg); */
  animation-name: rotar_logo;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  animation-duration: 3s;
  animation-delay: 3s;
}
.nav .menu {
  display: flex;
  justify-content: space-around;
  grid-column: 4/7;
}
.nav .menu li {
  list-style: none;
}
.nav .menu a {
  text-decoration: none;
  color: white;
  cursor: pointer;
}
.nav .menu-bar {
  display: none;
}
.nav .carrito {
  grid-column: 8/9;
}

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: "Helvetica Neue";
}

.nav {
  /*background-color: black;*/
  display: grid;
  grid-template-columns: repeat(8, 1fr);
  align-items: center;
  color: white;
  background-image: linear-gradient(to right, rgb(252, 252, 255), rgb(15, 44, 68));
}
.nav .logo {
  width: 60px;
  height: 60px;
  grid-column: 2/3;
  transform: translate(-150px);
  /*transform: scale(1,1);*/
  /*transform: skew(20deg,10deg);*/
  /*transform: rotate(80deg); */
  animation-name: rotar_logo;
  animation-iteration-count: infinite;
  animation-timing-function: linear;
  animation-duration: 3s;
  animation-delay: 3s;
}
.nav .menu {
  display: flex;
  justify-content: space-around;
  grid-column: 4/7;
}
.nav .menu li {
  list-style: none;
}
.nav .menu a {
  text-decoration: none;
  color: white;
  cursor: pointer;
}
.nav .menu-bar {
  display: none;
}
.nav .carrito {
  grid-column: 8/9;
}

/*aniamciones*/
@keyframes rotar_logo {
  0% {
    transform: rotateX(0deg);
  }
  50% {
    transform: rotateX(180deg);
  }
  100% {
    transform: rotateX(360deg);
  }
}
/*animation de la app*/
.indumentariaUrbana {
  animation-name: bounce;
  /*nombre copiado desde la app*/
  animation-duration: 3s;
}

.principal {
  height: 80vh;
  background-image: url("../galeria/IMG_8008.JPG");
  background-size: cover;
  background-position: center;
  max-width: 100%;
  display: grid;
  grid-template-columns: repeat(10, 1fr);
  grid-template-rows: repeat(8, 1fr);
}

.principal .contenido {
  grid-column: 1/4;
  grid-row: 3/7;
  color: #fff;
}

.principal h3 {
  font-size: 30px;
  font-weight: 300;
}

.principal h1 {
  font-size: 40px;
  color: white;
  text-transform: uppercase;
}

.principal p {
  font-weight: 200;
}

.principal .boton {
  font-family: "Courier New";
  font-size: 19px;
  font-weight: 600;
  background: none;
  color: #fff;
  padding: 10px 20px;
  border: solid 2px white;
  border-radius: 15px;
  margin-top: 15px;
  cursor: pointer;
  height: 100px;
  width: 100px;
  transition: all 2s;
}

.principal .boton:hover {
  height: 200px;
  width: 200px;
  background-color: cyan;
  /*font-size: 114px;*/
  /*transform: skewY(25deg)*/
}

/*footer*/
.pieDePagina {
  display: grid;
  height: 88px;
  align-items: center;
  background-image: linear-gradient(to right, rgb(139, 139, 139), rgb(15, 44, 68));
  color: white;
  grid-template-areas: "desarrollado seguinos redes-sociales";
}

.pieDePagina .desarrollado {
  grid-area: desarrollado;
  display: flex;
  justify-content: center;
}

.pieDePagina .seguinos {
  grid-area: seguinos;
  display: flex;
  justify-content: center;
}

.pieDePagina .redes-sociales {
  grid-area: redes-sociales;
  display: flex;
  justify-content: space-evenly;
  font-size: 20px;
}

/*nosotros*/
/*main*/
.mainNos {
  height: 80vh;
  background-image: url(../galeria/IMG_8008.JPG);
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center;
  max-width: 100%;
  padding: 5em;
}

.nosotros {
  max-width: 25em;
  padding: 1.3em;
  margin: 0 auto;
  /*se posiciona al centro*/
  background-color: rgba(249, 247, 255, 0.854);
  font-weight: bold;
  border-radius: 0.5em !important;
  box-shadow: inset 1px 1px 22px 4px rgba(228, 226, 226, 0.833);
}

/*contacto*/
.mainContacto {
  height: 100vh;
  background-image: linear-gradient(to right, rgb(235, 229, 229), rgb(69, 148, 214));
  background-position: center;
  background-size: cover;
  max-width: 100%;
  padding: 3em;
}

.formulario1 {
  max-width: 30em;
  padding: 1.5em;
  margin: 0 auto;
  /*se posiciona al centro*/
  background-color: rgba(120, 119, 123, 0.3);
  font-weight: bold;
  border-radius: 0.5em !important;
  box-shadow: inset 1px 1px 22px 4px rgba(0, 0, 0, 0.85);
}

/*sale*/
.mainSale {
  height: 90vh;
  background-image: linear-gradient(to right, rgb(235, 229, 229), rgb(69, 148, 214));
  background-position: center;
  max-width: 100%;
  background-size: cover;
  padding: 2em;
}

/*catalogo*/
.mainCat {
  height: 80vh;
  background-image: linear-gradient(to right, rgb(235, 229, 229), rgb(69, 148, 214));
  background-position: center;
  max-width: 100%;
  background-size: cover;
  padding: 2em;
}

/*mediaqueries*/
@media screen and (max-width: 600px) {
  .nav {
    position: relative;
  }

  .nav .carrito {
    display: none;
  }

  .nav .menu-bar {
    display: block;
    grid-column: 8/9;
    font-size: 30px;
    cursor: pointer;
  }

  .nav {
    font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serifs;
  }

  .nav .menu {
    display: none;
  }

  /*main*/
  .principal .contenido {
    grid-row: 3/7;
  }

  .principal h1 {
    font-size: 25px;
  }

  .principal p {
    font-size: 12px;
  }

  .principal .boton {
    font-size: 10px;
    font-weight: 900;
    text-transform: uppercase;
    background-color: black;
    border: solid 1px white;
  }

  .mainContacto .h4 {
    grid-row: 1/1;
  }

  /*footer*/
  .pieDePagina {
    height: 110px;
  }

  .pieDePagina .seguinos {
    display: none;
  }

  .pieDePagina .desarrollado {
    font-size: 15px;
  }
}
/*otra forma de usar mediaqueries*/
@media (min-width: 601px) and (max-width: 900px) {
  .nav {
    position: relative;
  }

  .nav .carrito {
    display: none;
  }

  .nav .menu-bar {
    display: block;
    grid-column: 8/9;
    font-size: 30px;
    cursor: pointer;
  }

  .nav .menu {
    display: none;
  }
}
/*pseudoclase*/
.menu .enlace:hover {
  color: black;
}

.formulario .email:invalid {
  border: solid 2px red;
}

/*# sourceMappingURL=estilos.cs.map */
