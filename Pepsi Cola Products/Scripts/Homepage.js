window.addEventListener('load', () => {
    document.querySelector('.hero-section').classList.add('hero-loaded');
});

const scrollElements = document.querySelectorAll('.scroll-animate');

const elementInView = (el, offset = 0) => {
    const elementTop = el.getBoundingClientRect().top;
    return elementTop <= ((window.innerHeight || document.documentElement.clientHeight) - offset);
};

const displayScrollElement = (el) => {
    el.classList.add('visible');
};

const handleScrollAnimation = () => {
    scrollElements.forEach(el => {
        if (elementInView(el, 50)) {
            displayScrollElement(el);
        }
    })
};

window.addEventListener('scroll', () => { handleScrollAnimation(); });
window.addEventListener('load', () => { handleScrollAnimation(); });


//const observer = new IntersectionObserver((entries) => {
//    entries.forEach(entry => {
//        if (entry.isIntersecting) {
//            entry.target.classList.add("show");
//        }
//    });
//}, { threshold: 0.4 });

//document.querySelectorAll(".scroll-animate").forEach(el => observer.observe(el));




const heroCarousel = document.querySelector('#heroCarousel');

new bootstrap.Carousel(heroCarousel, {
    interval: 3000,   // auto scroll every 3 seconds
    pause: false,     // hindi titigil pag hover
    ride: 'carousel', // auto start
    wrap: true        // balik sa first slide
});