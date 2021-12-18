import Services from '../services'
import BannerTrajes from '../banners/trajes'
import wdAccesorios from '../widgets/accesorios'

const Home = `
 ${Services}
 ${BannerTrajes}
 ${await wdAccesorios()}
`

export default Home