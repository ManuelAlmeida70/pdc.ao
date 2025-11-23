// Variável global para armazenar o tipo de utilizador selecionado
let selectedUserType = null;

// Função para abrir modal de login
function openLogin() {
    document.getElementById('loginModal').classList.remove('hidden');
    document.getElementById('loginModal').classList.add('flex');
    document.body.style.overflow = 'hidden';
}

// Função para fechar modal de login
function closeLogin() {
    document.getElementById('loginModal').classList.add('hidden');
    document.getElementById('loginModal').classList.remove('flex');
    document.body.style.overflow = 'auto';
}

// Função para selecionar tipo de utilizador
function selectUserType(type) {
    selectedUserType = type;
    document.getElementById('userType').value = type;

    // Remover seleção anterior
    document.querySelectorAll('.user-type-btn').forEach(btn => {
        btn.classList.remove('border-green-500', 'bg-green-50');
        btn.classList.add('border-gray-200');
    });

    // Adicionar seleção atual
    const selectedBtn = document.querySelector(`[data-type="${type}"]`);
    selectedBtn.classList.add('border-green-500', 'bg-green-50');
    selectedBtn.classList.remove('border-gray-200');
}

// Função para alternar visibilidade da password
function togglePassword() {
    const passwordInput = document.getElementById('password');
    const eyeIcon = document.getElementById('eyeIcon');
    if (passwordInput.type === 'password') {
        passwordInput.type = 'text';
        eyeIcon.textContent = '🙈';
    } else {
        passwordInput.type = 'password';
        eyeIcon.textContent = '👁️';
    }
}

// Função para processar o login
function handleLogin(event) {
    event.preventDefault();

    if (!selectedUserType) {
        alert('Por favor, selecione o tipo de utilizador');
        return;
    }

    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    // Simulação de login (aqui você conectaria com o backend)
    console.log('Login:', { userType: selectedUserType, username, password });

    // Mostrar mensagem de sucesso
    alert(`Login realizado com sucesso como ${selectedUserType}!\n\nUtilizador: ${username}`);

    // Fechar modal
    closeLogin();

    // Resetar formulário
    document.getElementById('loginForm').reset();
    selectedUserType = null;
    document.querySelectorAll('.user-type-btn').forEach(btn => {
        btn.classList.remove('border-green-500', 'bg-green-50');
        btn.classList.add('border-gray-200');
    });
}

// Adicionar event listeners aos botões de login
document.addEventListener('DOMContentLoaded', function () {
    // Adicionar evento aos botões que devem abrir o modal
    document.querySelectorAll('button').forEach(button => {
        const buttonText = button.textContent.trim();
        if (buttonText.includes('Iniciar sessão') ||
            buttonText.includes('Ver especialidades') ||
            buttonText.includes('Começar Agora') ||
            buttonText.includes('Solicitar Demo') ||
            buttonText.includes('Solicitar Demonstração')) {
            button.onclick = openLogin;
        }
    });

    // Fechar modal ao clicar fora
    document.getElementById('loginModal').addEventListener('click', function (e) {
        if (e.target === this) {
            closeLogin();
        }
    });

    // Smooth scroll para links internos - CORRIGIDO
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            const href = this.getAttribute('href');

            // Só aplicar smooth scroll se for uma âncora válida (#alguma-coisa)
            if (href && href.length > 1 && href.startsWith('#')) {
                e.preventDefault();
                const target = document.querySelector(href);
                if (target) {
                    target.scrollIntoView({ behavior: 'smooth', block: 'start' });
                }
            }
        });
    });

    // Animação dos elementos ao fazer scroll
    const observerOptions = {
        threshold: 0.1,
        rootMargin: '0px 0px -100px 0px'
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.opacity = '1';
                entry.target.style.transform = 'translateY(0)';
            }
        });
    }, observerOptions);

    document.querySelectorAll('section > div').forEach(el => {
        el.style.opacity = '0';
        el.style.transform = 'translateY(20px)';
        el.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
        observer.observe(el);
    });
});