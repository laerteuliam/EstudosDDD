moduloPessoa.directive('modalPessoa', function () {
    return {
        strict:'E',
        templateUrl: 'Scripts/directives/pessoaHtml/modal-pessoa.html'
    };
});

moduloPessoa.directive('listarPessoas', function () {
    return {
        strict:'E',
        templateUrl: 'Scripts/directives/pessoaHtml/listar-pessoas.html'
    };
});

moduloPessoa.directive('indexPessoa', function () {
    return {
        strict:'E',
        templateUrl: 'Scripts/directives/pessoaHtml/index-pessoa.html'
    };
});

moduloPessoa.directive('adicionarPessoa', function () {
    return {
        strict:'E',
        templateUrl: 'Scripts/directives/pessoaHtml/adicionar-pessoa.html'
    };
});