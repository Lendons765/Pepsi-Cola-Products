// Hero fade-in on page load
window.addEventListener('load', () => {
    document.querySelector('.hero-section').classList.add('hero-loaded');
});

// Fade in sections when scrolled into view
const sections = document.querySelectorAll('.section-fade');

function checkSectionVisibility() {
    const triggerBottom = window.innerHeight * 0.85;

    sections.forEach(section => {
        const sectionTop = section.getBoundingClientRect().top;
        if (sectionTop < triggerBottom) {
            section.classList.add('show');
        }
    });
}

window.addEventListener('scroll', checkSectionVisibility);
window.addEventListener('load', checkSectionVisibility);


document.addEventListener("DOMContentLoaded", () => {

    const animatedItems = document.querySelectorAll(
        ".scroll-animate, .scroll-left, .scroll-right"
    );

    const observer = new IntersectionObserver(
        (entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add("show");
                    observer.unobserve(entry.target);
                }
            });
        },
        {
            threshold: 0.2
        }
    );

    animatedItems.forEach(item => observer.observe(item));
});




// Animate cards on scroll
const cards = document.querySelectorAll('.card-fade');

function showCards() {
    const triggerBottom = window.innerHeight * 0.85;

    cards.forEach(card => {
        const cardTop = card.getBoundingClientRect().top;

        if (cardTop < triggerBottom) {
            card.classList.add('show');
        }
    });
}

window.addEventListener('scroll', showCards);
window.addEventListener('load', showCards);