
















<script>
    function editarEspecialidade(nome) {
        document.getElementById('descricaoEditar').value = nome;
        }

    function eliminarEspecialidade(nome) {
        document.getElementById('especialidadeNome').textContent = nome;
        }

    // Exibir modal de sucesso automaticamente
    @if (TempData["Sucesso"] != null)
    {
        <text>
            window.addEventListener('DOMContentLoaded', function() {
                    var modalSucesso = new bootstrap.Modal(document.getElementById('modalSucesso'));
            modalSucesso.show();

            // Auto-fechar após 3 segundos (opcional)
            setTimeout(function() {
                modalSucesso.hide();
                    }, 3000);
                });
        </text>
    }

        // Exibir modal de erro automaticamente
    @if (TempData["Erro"] != null)
    {
        <text>
            window.addEventListener('DOMContentLoaded', function() {
                    var modalErro = new bootstrap.Modal(document.getElementById('modalErro'));
            modalErro.show();
                });
        </text>
    }
</script>




//function eliminarEspecialidade(id, descricao) {
//    // 1. Define a descrição da especialidade na mensagem de alerta
//    document.getElementById('especialidadeNome-eliminar').innerText = descricao;

//    // 2. Define o ID no campo input hidden para ser enviado ao Controller
//    document.getElementById('especialidadeId-eliminar').value = id;
//}