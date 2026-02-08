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
