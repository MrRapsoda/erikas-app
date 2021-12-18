import api from '../../api/api.instance';

/**
 * Renderiza una pequeña lista de productos
 * que puede usarse en la pagina de inicio
 */


/**
 * @return{ Template String } HTML del componente
 */
async function wdAccesorios(){
   let wdAccesorios = await wd_accesorios_container();

   return wdAccesorios;
}

function wd_accesorios_card(accesoriosInfo) {
   const { idAccesorio, tipoAccesorio, color, precio } = accesoriosInfo 
   
   return `
    <div class="col-sm-6 col-md-4 col-lg-4">
      <div class="box">
         <div class="option_container">
            <div class="options">
               <a href="" class="option1" data-id-accesorie=${ idAccesorio }>
               ${tipoAccesorio}
               </a>
               <!---<a href="" class="option2">
               Buy Now
               </a>--->
            </div>
         </div>
         <div class="img-box">
            <img src="./src/images/${tipoAccesorio.toLowerCase()}-${color.toLowerCase()}.jpg" alt="">
         </div>
         <div class="detail-box">
            <h5>
               ${tipoAccesorio}
            </h5>
            <h6>
               CRC ${precio}
            </h6>
         </div>
      </div>
   </div>
    `
}

async function wd_accesorios_container(){
   
   let accesorios = await getAccesorios()

   let lista_accesorios = ''
   accesorios.forEach( item => lista_accesorios += wd_accesorios_card(item));

    return `
    <section class="product_section layout_padding">
             <div class="container">
                <div class="heading_container heading_center">
                   <h2>
                      Nuestros <span>productos</span>
                   </h2>
                </div>
               
                <div id="productos" class="wd_productos_container d-flex flex-wrap flex-start">
                  ${lista_accesorios}
                </div>
    
                </div>
                
             </div>
          </section>
    `
};

/**
 * API Calls
 */

async function getAccesorios() {
   let endpoint = 'accesoriosses';

  let { data } = await api.get(endpoint)

  return data;
}

export default wdAccesorios;