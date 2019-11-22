//var enderecoSite = "https://localhost:44354";
//var enderecoAPI = "https://localhost:44354/api/v1";

var enderecoSite = "https://localhost:5001";
var enderecoAPI = "https://localhost:5001/api/v1";

var listaDeExercicios = [];
var listaDeAgrupamentos = [];

/*
 * Login no sistema
 */

$("#frmLogin").on("submit", function (event) {
    event.preventDefault();

    var professor = {
        Email: $("#Email").val(),
        Senha: $("#Senha").val()
    }

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/professor/login`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(professor),
        success: function (dados) {
            window.location.href = `${enderecoSite}/professor/`
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });
});

/*
 * Cadastrar Professor
 */

$("#frmCadastroProfessor").on("submit", function (event) {
    event.preventDefault();

    //Faz a validação dos campos antes de tentar enviar a requisição..
    if (!$("#frmCadastroProfessor").valid()) {
        return false; //Para a execução por aqui.
    }

    $("#btnEnviarRequisicao").attr("disabled", true)

    var professor = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        Salario: $("#Salario").val(),
        Admissao: $("#Admissao").val(),
        Demissao: $("#Demissao").val(),
        Turno: $("#Turno").val(),
        DataNascimento: $("#DataNascimento").val(),
        Telefone: $("#Telefone").val(),
        Sexo: $("#Sexo").val(),
        Email: $("#Email").val(),
        Senha: $("#Senha").val(),
        ConfirmacaoSenha: $("#Senha").val(),
        Endereco: {
            Cep: $("#Endereco_Cep").val(),
            Rua: $("#Endereco_Rua").val(),
            Numero: $("#Endereco_Numero").val(),
            Complemento: $("#Endereco_Complemento").val(),
            Bairro: $("#Endereco_Bairro").val(),
            Cidade: $("#Endereco_Cidade").val(),
            UF: $("#Endereco_UF").val()
        }
    }

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/professor`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(professor),
        success: function (dados) {
            PopUpDeSucesso(dados.msg);
            $('#frmCadastroProfessor')[0].reset();
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Editar Professor
 */

$("#frmEdicaoProfessor").on("submit", function (event) {
    event.preventDefault();

    //Faz a validação dos campos antes de tentar enviar a requisição..
    if (!$("#frmEdicaoProfessor").valid()) {
        return false; //Para a execução por aqui.
    }

    $("#btnEnviarRequisicao").attr("disabled", true)

    var professor = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        Salario: $("#Salario").val(),
        Admissao: $("#Admissao").val(),
        Demissao: $("#Demissao").val(),
        Turno: $("#Turno").val(),
        DataNascimento: $("#DataNascimento").val(),
        Telefone: $("#Telefone").val(),
        Sexo: $("#Sexo").val(),
        Email: $("#Email").val(),
        Senha: $("#Senha").val(),
        ConfirmacaoSenha: $("#Senha").val(),
        Endereco: {
            Cep: $("#Endereco_Cep").val(),
            Rua: $("#Endereco_Rua").val(),
            Numero: $("#Endereco_Numero").val(),
            Complemento: $("#Endereco_Complemento").val(),
            Bairro: $("#Endereco_Bairro").val(),
            Cidade: $("#Endereco_Cidade").val(),
            UF: $("#Endereco_UF").val()
        }
    }

    $.ajax({
        type: "Put",
        url: `${enderecoAPI}/professor`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(professor),
        success: function (dados) {
            PopUpDeSucesso(dados.msg);
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Cadastrar Aluno
 */

$("#frmCadastroAluno").on("submit", function (event) {
    event.preventDefault();

    //Faz a validação dos campos antes de tentar enviar a requisição..
    if (!$("#frmCadastroAluno").valid()) {
        return false; //Para a execução por aqui.
    }

    $("#btnEnviarRequisicao").attr("disabled", true)

    var aluno = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        DataCadastro: moment(new Date()).format("YYYY-MM-DD"),
        DataNascimento: $("#DataNascimento").val(),
        Telefone: $("#Telefone").val(),
        Sexo: $("#Sexo").val(),
        Email: $("#Email").val(),
        Endereco: {
            Cep: $("#Endereco_Cep").val(),
            Rua: $("#Endereco_Rua").val(),
            Numero: $("#Endereco_Numero").val(),
            Complemento: $("#Endereco_Complemento").val(),
            Bairro: $("#Endereco_Bairro").val(),
            Cidade: $("#Endereco_Cidade").val(),
            UF: $("#Endereco_UF").val()
        },
        Status: $("#Status").is(':checked')
    }

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/aluno`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(aluno),
        success: function (dados) {
            PopUpDeSucesso(dados.msg);
            $('#frmCadastroAluno')[0].reset();
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Editar Aluno
 */

$("#frmEdicaoAluno").on("submit", function (event) {
    event.preventDefault();

    //Faz a validação dos campos antes de tentar enviar a requisição..
    if (!$("#frmEdicaoAluno").valid()) {
        return false; //Para a execução por aqui.
    }

    $("#btnEnviarRequisicao").attr("disabled", true)

    var aluno = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        DataCadastro: $("#DataCadastro").val(),
        DataNascimento: $("#DataNascimento").val(),
        Telefone: $("#Telefone").val(),
        Sexo: $("#Sexo").val(),
        Email: $("#Email").val(),
        Endereco: {
            Cep: $("#Endereco_Cep").val(),
            Rua: $("#Endereco_Rua").val(),
            Numero: $("#Endereco_Numero").val(),
            Complemento: $("#Endereco_Complemento").val(),
            Bairro: $("#Endereco_Bairro").val(),
            Cidade: $("#Endereco_Cidade").val(),
            UF: $("#Endereco_UF").val()
        },
        Status: $("#Status").is(':checked')
    }

    $.ajax({
        type: "Put",
        url: `${enderecoAPI}/aluno`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(aluno),
        success: function (dados) {
            PopUpDeSucesso(dados.msg);
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false);
});

/*
 * Cadastrar Tipo de Exercício
 */

$("#frmCadastroTipoDeExercicio").on("submit", function (event) {

    //Faz a validação dos campos antes de tentar enviar a requisição..
    if (!$("#frmCadastroTipoDeExercicio").valid()) {
        return false; //Para a execução por aqui.
    }

    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var tipoDeExercicio = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        GrupoMuscular: $("#GrupoMuscular").val(),
        Situacao: $("#Situacao").is(':checked')
    }

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/TipoDeExercicio`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(tipoDeExercicio),
        success: function (dados) {
            PopUpDeSucesso(dados.msg);
            $('#frmCadastroTipoDeExercicio')[0].reset();
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Editar Tipo de Exercício
 */

$("#frmEdicaoTipoDeExercicio").on("submit", function (event) {

    //Faz a validação dos campos antes de tentar enviar a requisição..
    if (!$("#frmEdicaoTipoDeExercicio").valid()) {
        return false; //Para a execução por aqui.
    }

    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var tipoDeExercicio = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        GrupoMuscular: $("#GrupoMuscular").val(),
        Situacao: $("#Situacao").is(':checked')
    }

    $.ajax({
        type: "Put",
        url: `${enderecoAPI}/TipoDeExercicio`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(tipoDeExercicio),
        success: function (dados) {
            PopUpDeSucesso(dados.msg);
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg);
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/**
 * Quando o botão de Adicionar agrupamento é clicado
 */

$("#btnAdicionarAgrupamento").click(function () {

    $(".selectpicker").selectpicker();
    var descricao = $("#Agrupamento_Descricao").val();

    if (descricao == "") {
        PopUpDeAlerta("A descrição está em branco! Verifique, por favor.");
        return false;
    }

    let agrupamento = {
        Descricao: descricao,
        Exercicios: []
    };

    listaDeAgrupamentos.push(agrupamento);

    $("#tblAgrupamentoBody").append(`
    <tr>
        <td>${agrupamento.Descricao}</td>
    </tr>`);

    let option = document.createElement('option');

    $('#Exercicio_Agrupamento').append($(option).attr('value', agrupamento.Descricao).html(agrupamento.Descricao));
    $('.selectpicker').selectpicker('refresh');

    limparFormAgrupamentos();
});

/**
 * Quando o botão de Adicionar exercício é clicado
 */

$("#btnAdicionarExercicio").click(function () {
    var agrupamento = $("#Exercicio_Agrupamento").prop('selectedIndex') - 1;
    var agrupamentoText = $("#Exercicio_Agrupamento option:selected").html();
    var tipoExercicioId = $("#Exercicio_TipoExercicio option:selected").val();
    var tipoExercicioText = $("#Exercicio_TipoExercicio option:selected").html();
    var serie = $("#Exercicio_Serie").val();
    var repeticao = $("#Exercicio_Repeticao").val();

    if (agrupamento == -1) {
        PopUpDeAlerta("Nenhum agrupamento foi selecionado!");
        return false;
    }

    if (tipoExercicioId == "") {
        PopUpDeAlerta("Nenhum tipo de exercício foi selecionado!");
        return false;
    }

    if (serie == "") {
        PopUpDeAlerta("Nenhuma série foi definida!");
        return false;
    }

    if (repeticao == "") {
        PopUpDeAlerta("Nenhuma repetição foi definida!");
        return false;
    }
    let exercicio = {
        TipoExercicioId: tipoExercicioId,
        Serie: serie,
        Repeticao: repeticao
    };

    listaDeAgrupamentos[agrupamento].Exercicios.push(exercicio);

    listaDeExercicios.push(exercicio);

    $("#tblExerciciosBody").append(`
    <tr>
        <td>${agrupamentoText}</td>
        <td>${tipoExercicioText}</td>
        <td>${exercicio.Serie}</td>
        <td>${exercicio.Repeticao}</td>
    </tr>`);

    limparFormExercicios();
});

/**
 * Quando se clica no botão de remover na tabela de agrupamentos 
 */

$('#tblAgrupamento').on('click', '.remover', function () {
    var indice = this.parentElement.parentElement.rowIndex - 1;

    listaDeAgrupamentos.splice(indice, 1)

    $(this).closest('tr').remove();
});

/**
 * Quando se clica no botão de remover na tabela de exercícios 
 */

$('#tblExercicios').on('click', '.remover', function () {
    var indice = this.parentElement.parentElement.rowIndex - 1;

    listaDeAgrupamentos.find(function (dados) {
        return listaDeExercicios[indice]
    });

    listaDeExercicios.splice(indice, 1)

    $(this).closest('tr').remove();
});

/**
 * Reseta todos os campos do form de exercícios. 
 */
function limparFormExercicios() {
    $('#Exercicio_Agrupamento').prop("selectedIndex", 0).change();
    $('#Exercicio_TipoExercicio').prop("selectedIndex", 0).change();
    $("#Exercicio_Serie").val("");
    $("#Exercicio_Repeticao").val("");
}

/**
 * Reseta todos os campos do form de agrupamentos. 
 */
function limparFormAgrupamentos() {
    $("#Agrupamento_Descricao").val("");
}

/*
 * Cadastrar treino
 */

$("#frmCadastroTreino").on("submit", function (event) {
    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var treino = {
        AlunoId: $("#Treino_Aluno").val(),
        ProfessorId: $("#Treino_Professor").val(),
        Objetivo: $("#Treino_Objetivo").val(),
        DataInicio: moment($("#Treino_DataInicio").val(), "DD/MM/YYYY").format("YYYY-MM-DD"),
        DataFim: moment($("#Treino_DataFim").val(), "DD/MM/YYYY").format("YYYY-MM-DD"),
        Agrupamentos: listaDeAgrupamentos,
        Situacao: true
    };

    //Validações
    if (treino.AlunoId == null) {
        PopUpDeAlerta("Nenhum aluno foi selecionado!");
        $("#btnEnviarRequisicao").attr("disabled", false)
        return false;
    }

    if (treino.ProfessorId == null) {
        PopUpDeAlerta("Nenhum professor foi selecionado!");
        $("#btnEnviarRequisicao").attr("disabled", false)
        return false;
    }

    if (treino.Objetivo == null) {
        PopUpDeAlerta("Nenhum objetivo foi selecionado!");
        $("#btnEnviarRequisicao").attr("disabled", false)
        return false;
    }

    if (listaDeAgrupamentos.length == 0) {
        PopUpDeAlerta("Nenhum agrupamento foi definido!");
        $("#btnEnviarRequisicao").attr("disabled", false)
        return false;
    }

    var existeAgrupamentosVazios = false;
    listaDeAgrupamentos.forEach(function (value, index) {
        if (value.Exercicios.length == 0) {
            existeAgrupamentosVazios = true;
        }
    });

    if (existeAgrupamentosVazios == true) {
        PopUpDeAlerta("Há agrupamentos sem exercícios definidos!");
        $("#btnEnviarRequisicao").attr("disabled", false)
        return false;
    }

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/treino`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(treino),
        success: function (dados) {
            PopUpDeSucesso(dados.msg)
            limparFormTreinos();
        },
        error: function (dados) {
            PopUpDeErro(dados.responseJSON.msg)
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/**
 * Reseta todo o formulário de cadastro de treinos. 
 */
function limparFormTreinos() {
    listaDeAgrupamentos = []; //Reseta a lista de agrupamentos
    listaDeExercicios = []; //Reseta a lista de exercicios
    limparFormAgrupamentos();
    limparFormExercicios();
    $('#Treino_Aluno').prop("selectedIndex", 0).change();
    $('#Treino_Professor').prop("selectedIndex", 0).change();
    $("#Treino_Objetivo").prop("selectedIndex", 0).change();
    $("#Treino_DataInicio").val("");
    $("#Treino_DataFim").val("");
    //Limpa as duas tabelas (HTML).
    $("#tblExerciciosBody").empty()
    $("#tblAgrupamentoBody").empty()

}

/*
 * Cadastrar Histórico de Exercícios
 */

$("#btnSalvarHistorico").on("click", function (event) {
    event.preventDefault();
    $("#btnSalvarHistorico").attr("disabled", true)

    let historicosDosExercicios = [];
    let isValid = true;

    $('#tblFichaExercicios > tbody  > tr').each(function () {

        /**
         * Verifica se foram informadas as cargas utilizadas nos exercícios.
         */
        if (!$(this).find('#Exercicio_Quantidade').val()) {
            PopUpDeErro("Ops, informe a carga utilizada em todos os exercícios!");
            $(this).find('#Exercicio_Quantidade').focus();
            $("#btnSalvarHistorico").attr("disabled", false)
            isValid = false;
            return false;
        }

        let exercicio = {
            ExercicioId: $(this).find("#Exercicio_Id").text(),
            Quantidade: $(this).find('#Exercicio_Quantidade').val()
        }
        historicosDosExercicios.push(exercicio);
    });
    if (isValid) {
        $.ajax({
            type: "post",
            url: `${enderecoAPI}/HistoricoExercicio`,
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(historicosDosExercicios),
            success: function (dados) {
                PopUpDeSucesso(`${dados.msg} A página será recarregada em instantes.`);
                setTimeout(`location.href = '${enderecoSite}/aluno/';`, 3500);
            },
            error: function (dados) {
                PopUpDeErro(dados.responseJSON.msg);
                $("#btnSalvarHistorico").attr("disabled", false)
            }
        });
    }
});


/**
 * Retorna na tela um pop-up de alerta na tela do usuário.
 */

function PopUpDeAlerta(mensagem) {
    Swal.fire(
        `Atenção!`,
        `${mensagem}`,
        'warning',
    );
}

/**
 * Retorna na tela um pop-up de erro na tela do usuário.
 */

function PopUpDeErro(mensagem) {
    Swal.fire(
        `Atenção!`,
        `${mensagem}`,
        'error',
    );
}

/**
 * Retorna na tela um pop-up de sucesso na tela do usuário.
 */

function PopUpDeSucesso(mensagem) {
    Swal.fire(
        `Sucesso!`,
        `${mensagem}`,
        'success',
    );
}

/**
 * Retorna na tela um pop-up de informação na tela do usuário.
 */

function PopUpDeInformacao(mensagem) {
    Swal.fire(
        `Sucesso!`,
        `${mensagem}`,
        'info',
    );
}

function limparEndereco() {
    // Limpa valores dos campos de endereço dos formulários.

    $("#Endereco_Rua").val("");
    $("#Endereco_Bairro").val("");
    $("#Endereco_Cidade").val("");
    $("#Endereco_UF").val("");
}


$(document).ready(function () {

    /**
    * Máscaras 
    */

    $('.celular').mask('(00) 00000-0000');
    $('.cpf').mask('000.000.000-00', { reverse: true });
    $('.dinheiro').mask("###.00", { reverse: true });
    $('.cep').mask('00000-000');

    /**
     * Validação de clique dos botões vermelhos.
     */

    $(".operacao-de-risco").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?");
        if (resultado == false) {
            e.preventDefault();
        }
    });

    /**
    * Validação de CEP e busca no webservice da PostMon.
    */

    //Quando o campo cep perde o foco.
    $("#Endereco_Cep").blur(function () {

        //Nova variável "cep" somente com dígitos.
        var cep = $(this).val().replace(/\D/g, '');

        //Verifica se campo cep possui valor informado.
        if (cep != "") {

            //Expressão regular para validar o CEP.
            var validacep = /^[0-9]{8}$/;

            //Valida o formato do CEP.
            if (validacep.test(cep)) {

                //Preenche os campos enquanto consulta o webservice.
                $("#Endereco_Rua").val("Buscando dados, aguarde...");
                $("#Endereco_Bairro").val("Buscando dados, aguarde...");
                $("#Endereco_Cidade").val("Buscando dados, aguarde...");

                //Consulta o webservice viacep.com.br/
                $.getJSON(`https://api.postmon.com.br/v1/cep/${cep}?format=json`, function (dados) {

                    //Atualiza os campos com os valores da consulta.
                    $("#Endereco_Rua").val(dados.logradouro);
                    $("#Endereco_Bairro").val(dados.bairro);
                    $("#Endereco_Cidade").val(dados.cidade);
                    $("#Endereco_UF option").filter(function () {
                        return this.text == dados.estado_info.nome;
                    }).attr('selected', true);
                }).fail(function () {
                    limparEndereco();
                    alert("CEP não encontrado.");
                })
            } else {
                //cep é inválido.
                limparEndereco();
                alert("Formato de CEP inválido.");
            }
        } else {
            //cep sem valor, limpa formulário.
            alert("Por favor, informe o CEP.");
            limparEndereco();
        }
    });
});

/*
 * Formulário de Exclusão de Aluno
 */

$(".frmExclusaoAluno").on("submit", function (event) {
    event.preventDefault();

    let id = $(this).find("#id").val();
    let linha = $(this).closest('tr');


    $.ajax({
        type: "delete",
        url: `${enderecoAPI}/aluno`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(id),
        success: function (dados) {
            $(this).closest('tr').remove();
            PopUpDeInformacao("Aluno excluído com sucesso!");
            linha.remove();
        },
        error: function (dados) {
            PopUpDeErro("Houve um erro ao tentar excluir esse aluno, tente inativá-lo em seu cadastro.");
        }
    });
});

/*
 * Formulário de Exclusão de Professor
 */

$(".frmExclusaoProfessor").on("submit", function (event) {
    event.preventDefault();

    let id = $(this).find("#id").val();
    let linha = $(this).closest('tr');


    $.ajax({
        type: "delete",
        url: `${enderecoAPI}/professor`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(id),
        success: function (dados) {
            $(this).closest('tr').remove();
            PopUpDeInformacao("Professor excluído com sucesso!");
            linha.remove();
        },
        error: function (dados) {
            PopUpDeErro("Houve um erro ao tentar excluir esse professor, Se foi demitido, basta informar isso em seu cadastro e o mesmo será inativado.");
        }
    });
});

/*
 * Formulário de Exclusão de Tipos de Exercício
 */

$(".frmExclusaoTipoDeExercicio").on("submit", function (event) {
    event.preventDefault();

    let id = $(this).find("#id").val();
    let linha = $(this).closest('tr');


    $.ajax({
        type: "delete",
        url: `${enderecoAPI}/tipodeexercicio`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(id),
        success: function (dados) {
            $(this).closest('tr').remove();
            PopUpDeInformacao("Tipo de Exercício excluído com sucesso!");
            linha.remove();
        },
        error: function (dados) {
            PopUpDeErro("Houve um erro ao tentar excluir esse tipo de exercício, tente inativá-lo pelo botão ao lado.");
        }
    });
});

/*
 * Formulário de Exclusão de Treinos
 */

$(".frmExclusaoTreino").on("submit", function (event) {
    event.preventDefault();

    let id = $(this).find("#id").val();
    let linha = $(this).closest('tr');


    $.ajax({
        type: "delete",
        url: `${enderecoAPI}/treino`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(id),
        success: function (dados) {
            $(this).closest('tr').remove();
            PopUpDeInformacao("Treino excluído com sucesso!");
            linha.remove();
        },
        error: function (dados) {
            PopUpDeErro("Houve um erro ao tentar excluir esse treino, pois ele já foi executado. Tente inativá-lo na opção ao lado.");
        }
    });
});

/*
 * Formulário de Inativação de Treinos
 */

$(".frmInativacaoTreino").on("submit", function (event) {
    event.preventDefault();

    let id = $(this).find("#id").val();
    let button = $(this).find("#btnInativacao");

    $.ajax({
        type: "patch",
        url: `${enderecoAPI}/treino`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(id),
        success: function (dados) {

            if (button.val() == "Ativar") {
                button.val("Inativar");
            } else {
                button.val("Ativar")
            }

            PopUpDeInformacao(dados.msg);
        },
        error: function (dados) {
            PopUpDeErro("Houve um erro ao tentar fazer a operação. Tente novamente.");
        }
    });
});

/*
 * Formulário de Inativação de Tipos de Exercícios
 */

$(".frmInativacaoTipoDeExercicio").on("submit", function (event) {
    event.preventDefault();

    let id = $(this).find("#id").val();
    let button = $(this).find("#btnInativacao");

    $.ajax({
        type: "patch",
        url: `${enderecoAPI}/TipoDeExercicio`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(id),
        success: function (dados) {

            if (button.val() == "Ativar") {
                button.val("Inativar");
            } else {
                button.val("Ativar")
            }

            PopUpDeInformacao(dados.msg);
        },
        error: function (dados) {
            PopUpDeErro("Houve um erro ao tentar fazer a operação. Tente novamente.");
        }
    });
});