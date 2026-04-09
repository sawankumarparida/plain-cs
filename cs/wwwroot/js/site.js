<script>
    const themeToggle = document.getElementById('themeToggle');
    const themeIcon = document.getElementById('themeIcon');
    const htmlElement = document.documentElement;

    // 1. On Load: Check for saved preference
    const savedTheme = localStorage.getItem('theme') || 'light';
    htmlElement.setAttribute('data-bs-theme', savedTheme);
    updateIcon(savedTheme);

    // 2. Click Event: Toggle theme
    themeToggle.addEventListener('click', () => {
        const currentTheme = htmlElement.getAttribute('data-bs-theme');
        const newTheme = currentTheme === 'light' ? 'dark' : 'light';
        
        htmlElement.setAttribute('data-bs-theme', newTheme);
        localStorage.setItem('theme', newTheme);
        updateIcon(newTheme);
    });

    function updateIcon(theme) {
        if (theme === 'dark') {
            themeIcon.classList.replace('fa-moon', 'fa-sun');
            themeIcon.style.color = '#ffc107'; // Sun yellow
        } else {
            themeIcon.classList.replace('fa-sun', 'fa-moon');
            themeIcon.style.color = '#6c757d'; // Moon grey
        }
    }
</script>