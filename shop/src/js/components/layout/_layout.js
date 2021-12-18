import Header from '../header'
import Footer from '../footer'
import HeroSlider from '../hero'

function _layout(ui, config = {}){
    return `
        <div class="hero-area">
            ${Header}
            ${config.showHero ? HeroSlider: '' }
        </div>

        ${ui ? ui: 'No hay contenido'}

        ${Footer}
    `
}

export default _layout;