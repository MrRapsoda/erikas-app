import api from '../../api/api.instance'
const BASE_URL = 'http://localhost:3000/'
function default_producto_card(producto){
    return `
<div class="col-sm-6 col-md-5 col-lg-3">
    <div class="box">
       <div class="option_container">
          <div class="options">
             <a href="#" class="option1">
             ${producto.nombre || producto.tipoAccesorio}
             </a>
             <a href="#" class="option2">
             Ver ahora
             </a>
          </div>
       </div>
       <div class="img-box">
          <img src="${BASE_URL}src/images/f0451b5b-71b2-44f2-bf09-4c1455497a7f.jpg" alt="">
       </div>
       <div class="detail-box">
          <h5>
             ${producto.nombre || producto.tipoAccesorio}
          </h5>
          <h6>
             CRC ${producto.precio}
          </h6>
       </div>
    </div>
 </div>
    `
}

async function Producto(tipo = 'Productos') {
    let cardsProductos = '';
    let productos = []

    switch (tipo) {
        case 'Vestidos':
            productos = await getVestidos('n')
            break;

        case 'Vestidos quinceaños':
            productos = await getVestidos('q')
            break;
        case 'Trajes':
            productos = await getTrajes()
            break;

        case 'Accesorios':
            productos = await getAccesorios()
            break;
        default:
            productos = []
            break
    }
    
    //console.log('Productos: ', productos)

    if(Array.isArray(productos)){
        productos.forEach((producto) => {
            cardsProductos += default_producto_card(producto)
        })
    }

    //console.log(cardsProductos)

    return `
    <section class="product_section layout_padding">
         <div class="container">
            <div class="heading_container heading_center">
               <h2>
                  <span>${tipo}</span>
               </h2>
                
               <div class="container d-flex flex-wrap">
                  ${await cardsProductos}
               </div>
            </div>
        </div>
    </section>
    `
}

////////////////////
////  API Calls ////
////////////////////
async function getTrajes(){
    let endpoint = 'Trajes2';

    let { data } = await api.get(endpoint)

    return data
}

async function getVestidos(tipo){
    let endpoint = tipo == 'n' ? 'Vestidoes' : 'VQuinceanos'

    let { data } = await api.get(endpoint)

    return data
}

async function getAccesorios(){

    let endpoint = 'accesoriosses'

    let { data } = await api.get(endpoint)

    return data
}
export default Producto;