!function(t){"use strict";t(".woocommerce-form-coupon-toggle .showcoupon").on("click",function(){t(this).toggleClass("active"),t(this).hasClass("active")?t(".woocommerce-form-coupon").stop(!0,!0).slideDown():t(".woocommerce-form-coupon").stop(!0,!0).slideUp()}),t(window).on("scroll",function(){t(".ot-counter").each(function(){var e=t(this).offset().top-window.innerHeight,o=t(this).find(".num"),i=o.attr("data-to"),s=parseInt(o.attr("data-time"));e<t(window).scrollTop()&&t({countNum:o.text()}).animate({countNum:i},{duration:s,easing:"swing",step:function(){o.text(Math.floor(this.countNum))},complete:function(){o.text(this.countNum)}})})}),t(window).on("scroll",function(){t(".ot-progress").each(function(){var e=t(this).offset().top,o=t(this).find(".progress-bar").data("percent");e<t(window).scrollTop()+900&&t(this).find(".progress-bar").css({width:o},"slow")})}),t(window).on("scroll",function(){t(".circle-progress").each(function(){var e=t(this).data("color1"),o=t(this).data("color2");t(this).offset().top<t(window).scrollTop()+900&&t(this).find(".inner-bar").easyPieChart({barColor:function(t){var i=this.renderer.getCtx().createLinearGradient(45,0,0,90);return i.addColorStop(0,e),i.addColorStop(1,o),i},trackColor:!1,scaleColor:!1,lineCap:"round",lineWidth:20,size:195,animate:1e3,onStart:t.noop,onStop:t.noop,easing:"easeOutBounce",onStep:function(e,o,i){t(this.el).find(".percent").text(Math.round(i))}})})}),t(window).on("load",function(){t(".ot-tabs").each(function(){t(this).find(".tabs-heading li").first().addClass("current"),t(this).find(".tab-content").first().addClass("current")}),t(".tabs-heading li").on("click",function(){var e=t(this).attr("data-tab");t(this).siblings().removeClass("current"),t(this).parents(".ot-tabs").find(".tab-content").removeClass("current"),t(this).addClass("current"),t("#"+e).addClass("current")})}),t(".ot-accordions").each(function(){var e=t(this).find(".acc-content");t(this).find(".acc-toggle").on("click",function(){var o=t(this).next();return o.hasClass("active")||(e.removeClass("active").slideUp(300),e.parent().removeClass("current"),o.addClass("active").slideDown(300),o.parent().addClass("current")),!1}),t(this).find(".acc-toggle:first").trigger("click")}),t(".ot-testimonials-slider").each(function(){t(this).slick({slidesToShow:1,slidesToScroll:1,arrows:!0,dots:!1,autoplay:!0,autoplaySpeed:6e3,adaptiveHeight:!0,fade:!0,appendArrows:".testicustom-slider-nav, .slider__arrows",prevArrow:'<button type="button" class="prev-nav"><i class="flaticon-arrow-pointing-to-left"></i></button>',nextArrow:'<button type="button" class="next-nav"><i class="flaticon-arrow-pointing-to-right"></i></button>'})}),t(".home-client-carousel").each(function(){t(this).slick({slidesToShow:6,slidesToScroll:1,arrows:!1,autoplaySpeed:1500,dots:!1,autoplay:!0,responsive:[{breakpoint:1199,settings:{slidesToShow:4,slidesToScroll:1,infinite:!0,arrows:!1,dots:!1}},{breakpoint:991,settings:{slidesToShow:4,slidesToScroll:1,infinite:!0,arrows:!1,dots:!1}},{breakpoint:600,settings:{slidesToShow:2,slidesToScroll:1,arrows:!1,dots:!1}}]})}),t(window).on("load",function(){t(".message-box > i").on("click",function(){t(this).parent().fadeOut()})}),t(window).on("load",function(){t(".projects-grid").each(function(){var e=t(this);e.isotope({itemSelector:".project-item",animationEngine:"css",masonry:{columnWidth:1}});var o=t(".project_filters");o.find("a").on("click",function(){var i=t(this);if(i.hasClass("selected"))return!1;i.parents(".project_filters");o.find(".selected").removeClass("selected"),i.addClass("selected");var s=t(this).attr("data-filter");return e.isotope({filter:s}),!1})})}),t(".project-slider").each(function(){t(this).not(".slick-initialized").slick({slidesToShow:3,slidesToScroll:3,arrows:!1,dots:!0,autoplay:!0,autoplaySpeed:6e3,adaptiveHeight:!0,prevArrow:'<button type="button" class="prev-nav"><i class="flaticon-arrow-pointing-to-left"></i></button>',nextArrow:'<button type="button" class="next-nav"><i class="flaticon-arrow-pointing-to-right"></i></button>',responsive:[{breakpoint:1199,settings:{slidesToShow:3,slidesToScroll:1,infinite:!0,arrows:!1,dots:!0}},{breakpoint:991,settings:{slidesToShow:2,slidesToScroll:1,infinite:!0,arrows:!1,dots:!0}},{breakpoint:600,settings:{slidesToShow:1,slidesToScroll:1,arrows:!1,dots:!0}}]})}),t(".slider-product, .slider-product-nav").length&&(t(".slider-product").slick({slidesToShow:1,slidesToScroll:1,arrows:!1,fade:!0,asNavFor:".slider-product-nav",autoplay:!1}),t(".slider-product-nav").slick({slidesToShow:4,slidesToScroll:4,asNavFor:".slider-product",dots:!1,arrows:!1,centerMode:!1,focusOnSelect:!0,useTransform:!1})),t(".team-social > span").on("click",function(){t(this).parent().toggleClass("active")}),t(".team-slider").each(function(){t(this).not(".slick-initialized").slick({slidesToShow:3,slidesToScroll:1,arrows:!1,dots:!0,infinite:!1,autoplay:!0,autoplaySpeed:6e3,adaptiveHeight:!0,prevArrow:'<button type="button" class="prev-nav"><i class="flaticon-arrow-pointing-to-left"></i></button>',nextArrow:'<button type="button" class="next-nav"><i class="flaticon-arrow-pointing-to-right"></i></button>',responsive:[{breakpoint:1199,settings:{slidesToShow:3,slidesToScroll:1,infinite:!0,arrows:!1,dots:!0}},{breakpoint:991,settings:{slidesToShow:2,slidesToScroll:1,infinite:!0,arrows:!1,dots:!0}},{breakpoint:600,settings:{slidesToShow:1,slidesToScroll:1,arrows:!1,dots:!0}}]})}),t(".team-slider-h5").each(function(){t(this).not(".slick-initialized").slick({slidesToShow:5,slidesToScroll:1,arrows:!1,dots:!0,infinite:!1,autoplay:!0,autoplaySpeed:6e3,adaptiveHeight:!0,prevArrow:'<button type="button" class="prev-nav"><i class="flaticon-arrow-pointing-to-left"></i></button>',nextArrow:'<button type="button" class="next-nav"><i class="flaticon-arrow-pointing-to-right"></i></button>',responsive:[{breakpoint:1199,settings:{slidesToShow:3,slidesToScroll:1,infinite:!0,arrows:!1,dots:!0}},{breakpoint:991,settings:{slidesToShow:2,slidesToScroll:1,infinite:!0,arrows:!1,dots:!0}},{breakpoint:600,settings:{slidesToShow:1,slidesToScroll:1,arrows:!1,dots:!0}}]})}),t(".real-numbers").each(function(){t(".real-numbers").find(".switch input").on("change",function(){var e=t(this).parents(".real-numbers");this.checked?(e.find(".a-switch").addClass("active"),e.find(".b-switch").removeClass("active"),e.find("h2.after").fadeIn(),e.find("h2.before").hide()):(e.find(".b-switch").addClass("active"),e.find(".a-switch").removeClass("active"),e.find("h2.after").hide(),e.find("h2.before").fadeIn())})}),t(".tab-titles .title-item").on("click",function(){return t(".tab-active").removeClass("tab-active"),t(this).addClass("tab-active"),t("#content-tabs .section-content").removeClass("active"),t(t(this).attr("href")).addClass("active"),!1}),t(".tab-titles .title-item:first").trigger("click"),t(".tab-titles").each(function(){t(this).not(".slick-initialized").slick({slidesToShow:6,slidesToScroll:1,arrows:!1,infinite:!1,autoplay:!1,adaptiveHeight:!0,prevArrow:'<button type="button" class="prev-nav"><i class="flaticon-arrow-pointing-to-left"></i></button>',nextArrow:'<button type="button" class="next-nav"><i class="flaticon-arrow-pointing-to-right"></i></button>',responsive:[{breakpoint:1199,settings:{slidesToShow:5,slidesToScroll:1,dots:!0}},{breakpoint:991,settings:{slidesToShow:4,slidesToScroll:1,dots:!0}},{breakpoint:767,settings:{slidesToShow:3,slidesToScroll:1,dots:!0}},{breakpoint:600,settings:{slidesToShow:2,slidesToScroll:1,dots:!0}},{breakpoint:480,settings:{slidesToShow:1,slidesToScroll:1,dots:!0}}]})}),t(".ot-countdown").each(function(){t(this).countdown({date:"2020/06/10 12:00",offset:"0",day:"Day",days:"Days",hour:"Hour",hours:"Hours",minute:"Minute",minutes:"Minutes",second:"Second",seconds:"Seconds"},function(){alert("Done!")})}),t(".gallery-post").each(function(){t(this).slick({infinite:!0,slidesToShow:1,slidesToScroll:1,arrows:!0,dots:!1,autoplay:!0,autoplaySpeed:7e3,prevArrow:'<button type="button" class="prev-nav"><i class="flaticon-arrow-pointing-to-left"></i></button>',nextArrow:'<button type="button" class="next-nav"><i class="flaticon-arrow-pointing-to-right"></i></button>',responsive:[]})});var e=t(".btn-play");e.length>0&&e.magnificPopup({type:"iframe",removalDelay:160,preloader:!0,fixedContentPos:!0,callbacks:{beforeOpen:function(){this.st.image.markup=this.st.image.markup.replace("mfp-figure","mfp-figure mfp-with-anim"),this.st.mainClass=this.st.el.attr("data-effect")}}}),t(window).load(function(){t(".particles-js").each(function(){var e=t(this).data("id"),o=(o=t(this).data("color")).replace(/\s/g,""),i=t('<div class="onum-particles"></div>');t(this).append(i),i.attr("id","particles-"+e);var s,n="particles-"+e,a=o,r="#fff";r=(a=a.split(","))[0],particlesJS(n,{particles:{number:{value:15,density:{enable:!0,value_area:800}},color:{value:a},shape:{type:"circle",polygon:{nb_sides:6}},opacity:{value:1,random:!0,anim:{enable:!1,speed:1,opacity_min:1,sync:!1}},size:{value:3,random:!0,anim:{enable:!1,speed:30,size_min:1,sync:!1}},line_linked:{enable:!1,distance:150,color:r,opacity:0,width:1},move:{enable:!0,speed:2,direction:"none",random:!1,straight:!1,out_mode:"out",bounce:!1,attract:{enable:!1,rotateX:600,rotateY:1200}}},interactivity:{detect_on:"canvas",events:{onhover:{enable:!0,mode:"grab"},onclick:{enable:!0,mode:"push"},resize:!0},modes:{grab:{distance:150,line_linked:{opacity:1}},bubble:{distance:200,size:3.2,duration:20,opacity:1,speed:30},repulse:{distance:80,duration:.4},push:{particles_nb:4},remove:{particles_nb:2}}},retina_detect:!0}),s=function(){requestAnimationFrame(s)},requestAnimationFrame(s)})}),t(window).load(function(){t(".particles-js-b").each(function(){var e=t(this).data("id"),o=(o=t(this).data("color")).replace(/\s/g,""),i=t('<div class="onum-particles"></div>');t(this).append(i),i.attr("id","particles-"+e);var s,n="particles-"+e,a=o,r="#fff";r=(a=a.split(","))[0],particlesJS(n,{particles:{number:{value:15,density:{enable:!0,value_area:800}},color:{value:a},shape:{type:"circle",polygon:{nb_sides:6}},opacity:{value:1,random:!0,anim:{enable:!1,speed:1,opacity_min:1,sync:!1}},size:{value:4,random:!0,anim:{enable:!1,speed:30,size_min:1,sync:!1}},line_linked:{enable:!1,distance:150,color:r,opacity:0,width:1},move:{enable:!0,speed:2,direction:"none",random:!1,straight:!1,out_mode:"out",bounce:!1,attract:{enable:!1,rotateX:600,rotateY:1200}}},interactivity:{detect_on:"canvas",events:{onhover:{enable:!0,mode:"grab"},onclick:{enable:!0,mode:"push"},resize:!0},modes:{grab:{distance:150,line_linked:{opacity:1}},bubble:{distance:200,size:3.2,duration:20,opacity:1,speed:30},repulse:{distance:80,duration:.4},push:{particles_nb:4},remove:{particles_nb:2}}},retina_detect:!0}),s=function(){requestAnimationFrame(s)},requestAnimationFrame(s)})}),t(window).load(function(){if(t("#projects_grid").length>0){(o=t("#projects_grid")).isotope({itemSelector:".project-item",layoutMode:"masonry"});var e=t(".project_filters");e.find("a").click(function(){var i=t(this);if(i.hasClass("selected"))return!1;i.parents(".project_filters");e.find(".selected").removeClass("selected"),i.addClass("selected");var s=t(this).attr("data-filter");return o.isotope({filter:s}),!1})}var o;t(".blog-grid").length>0&&(o=t(".blog-grid")).isotope({itemSelector:".masonry-post-item",layoutMode:"masonry"})})}(jQuery);

function set_banner_image() {
  if(document.querySelector('.page-banner img')) {
    if(window.outerWidth > 900)
    document.querySelector('.page-banner img').src = 'images/bg-page-header.jpg';
  else
    if(window.outerWidth <= 900 && window.outerWidth >= 500)
      document.querySelector('.page-banner img').src = 'images/bg-page-header-tab.jpg';
    else
      if(window.outerWidth < 500)
        document.querySelector('.page-banner img').src = 'images/bg-page-header-mobile.png';  
  }
}

window.onresize = set_banner_image;
window.onload = set_banner_image;