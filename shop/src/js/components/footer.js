const meta = {
    tel: '',
    email: '',
    social: {
        fb: '',
        instagram: '',
        whatsapp: ''
    }
}

const footer = `
<footer class="footer_section">
<div class="container">
   <div class="row">
      <div class="col-md-4 footer-col">
         <div class="footer_contact">
            <h4>
               Reach at..
            </h4>
            <div class="contact_link_box">
               <a href="">
               <i class="fa fa-map-marker" aria-hidden="true"></i>
               <span>
               Location
               </span>
               </a>
               <a href="">
               <i class="fa fa-phone" aria-hidden="true"></i>
               <span>
               Llamanos al ${meta.tel}
               </span>
               </a>
               <a href="">
               <i class="fa fa-envelope" aria-hidden="true"></i>
               <span>
               ${meta.email}
               </span>
               </a>
            </div>
         </div>
      </div>
      <div class="col-md-4 footer-col">
         <div class="footer_detail">
            <a href="/" data-navigo class="footer-logo">
            Erikas
            </a>
            <p>
               Necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with
            </p>
            <div class="footer_social">
               <a href="${meta.social.fb}">
               <i class="fa fa-facebook" aria-hidden="true"></i>
               </a>
               
               <a href="${meta.social.instagram}">
               <i class="fa fa-instagram" aria-hidden="true"></i>
               </a>
               
            </div>
         </div>
      </div>
      <div class="col-md-4 footer-col">
         <div class="map_container">
            <div class="map">
               <div id="googleMap"></div>
            </div>
         </div>
      </div>
   </div>
   <div class="footer-info">
      <div class="col-lg-7 mx-auto px-0">
         <p>
            
         </p>
      </div>
   </div>
</div>
</footer>
`

export default footer;