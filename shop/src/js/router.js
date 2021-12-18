import Navigo from 'navigo'
import _layout from './components/layout/_layout'
import Home from './components/pages/home'
import Producto from './components/pages/product'
function initRouter(){
    
    const router = new Navigo('/')
    
    router.hooks({
        before(done, match) {
            router.updatePageLinks()
            done()
        },
        after(done, match) {
            router.updatePageLinks()
            //done()
        }
    })

    router.on('/', () => {
        console.log('on /')
        render({
            ui: _layout(Home, {
                showHero: true
            })
        })
    })

    router.on('/vestidos/quince', async () => {
        render({
            ui: _layout(await Producto('Vestidos quinceaños'))
        })
    })

    router.on('/vestidos/novia', async () => {
        render({
            ui: _layout(await Producto('Vestidos'))
        })
    })

    router.on('/trajes', async () => {
        render({
            ui: _layout(await Producto('Trajes'))
        })
    })

    router.on('/accesorios', async () => {
        render({
            ui: _layout(await Producto('Accesorios'))
        })
    })

    router.notFound(() => {
        console.log('route not found')
    })

    router.resolve()

}


function render(config = {}) {
    const app = document.querySelector(`${config.container || '#app'}`)

    app.innerHTML = config.ui;
}

export default initRouter;