import logo from '../../images/LogoWeb.jpg'

const Header = `
<header class="header_section">
            <div class="container">
               <nav class="navbar navbar-expand-lg custom_nav-container ">
                  <a class="navbar-brand" href="index.html"><img width="250" src="${logo}" alt="#" /></a>
                  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                  <span class=""> </span>
                  </button>
                  <div class="collapse navbar-collapse" id="navbarSupportedContent">
                     <ul class="navbar-nav">
                        <li class="nav-item">
                           <a class="nav-link" href="/" data-navigo>Inicio<span class="sr-only"></span></a>
                        </li>
                       <li class="nav-item dropdown">
                           <a class="nav-link dropdown-toggle" href="#" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true"> <span class="nav-label">Vestidos <span class="caret"></span></a>
                           <ul class="dropdown-menu">
                              <li><a href="/vestidos/quince" data-navigo>Quinceaños</a></li>
                              <li><a href="/vestidos/novia" data-navigo>De novia</a></li>
                           </ul>
                        </li>
                        <li class="nav-item">
                           <a class="nav-link" href="/trajes" data-navigo>Trajes</a>
                        </li>
                        <li class="nav-item">
                           <a class="nav-link" href="/accesorios" data-navigo>Accesorios</a>
                        </li>
                        
                     </ul>
                  </div>
               </nav>
            </div>
         </header>
`;

export default Header;