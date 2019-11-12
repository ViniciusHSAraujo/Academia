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
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });
});

/*
 * Cadastrar Professor
 */

$("#frmCadastroProfessor").on("submit", function (event) {
    event.preventDefault();
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
            Swal.fire(
                `Sucesso!`,
                `${dados.msg}`,
                'success',
            );
            $('#frmCadastroProfessor')[0].reset();
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Editar Professor
 */

$("#frmEdicaoProfessor").on("submit", function (event) {
    event.preventDefault();
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
            Swal.fire(
                `Sucesso!`,
                `${dados.msg}`,
                'success',
            );
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Cadastrar Aluno
 */

$("#frmCadastroAluno").on("submit", function (event) {
    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var aluno = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        DataCadastro: new Date().toLocaleString(),
        DataNascimento: $("#DataNascimento").val(),
        Telefone: $("#Telefone").val(),
        Sexo: $("#Sexo").val(),
        Email: $("#Email").val(),
        Senha: $("#Senha").val(),
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
            Swal.fire(
                `Sucesso!`,
                `${dados.msg}`,
                'success',
            );
            $('#frmCadastroAluno')[0].reset();
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Editar Aluno
 */

$("#frmEdicaoAluno").on("submit", function (event) {
    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var aluno = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        DataCadastro: $("#DataCadastro").val(),
        DataNascimento: $("#DataNascimento").val(),
        Telefone: $("#Telefone").val(),
        Sexo: $("#Sexo").val(),
        Email: $("#Email").val(),
        Senha: $("#Senha").val(),
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
            Swal.fire(
                `Sucesso!`,
                `${dados.msg}`,
                'success',
            );
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false);
});

/*
 * Cadastrar Tipo de Exercício
 */

$("#frmCadastroTipoDeExercicio").on("submit", function (event) {
    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var tipoDeExercicio = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        GrupoMuscular: $("#GrupoMuscular").val()
    }

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/TipoDeExercicio`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(tipoDeExercicio),
        success: function (dados) {
            Swal.fire(
                `Sucesso!`,
                `${dados.msg}`,
                'success',
            );
            $('#frmCadastroTipoExercicio')[0].reset();
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

/*
 * Editar Tipo de Exercício
 */

$("#frmEdicaoTipoDeExercicio").on("submit", function (event) {
    event.preventDefault();
    $("#btnEnviarRequisicao").attr("disabled", true)

    var tipoDeExercicio = {
        Id: $("#Id").val(),
        Nome: $("#Nome").val(),
        GrupoMuscular: $("#GrupoMuscular").val()
    }

    $.ajax({
        type: "patch",
        url: `${enderecoAPI}/TipoDeExercicio`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(tipoDeExercicio),
        success: function (dados) {
            Swal.fire(
                `Sucesso!`,
                `${dados.msg}`,
                'success',
            );
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
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

    let agrupamento = {
        Descricao: descricao,
        Exercicios: []
    };

    listaDeAgrupamentos.push(agrupamento);

    $("#tblAgrupamentoBody").append(`
    <tr>
        <td>${agrupamento.Descricao}</td>
        <td><button class="btn btn-danger remover-exercicio" id="excluir">Excluir</button></td>
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
        <td>${exercicio.Series}</td>
        <td>${exercicio.Repeticoes}</td>
        <td><button class="btn btn-danger remover-exercicio" id="excluir">Excluir</button></td>
    </tr>`);

    limparFormExercicios();
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
        DataInicio: moment($("#Treino_DataInicio")).format("YYYY-MM-DD HH:mm:ss"),
        DataFim: moment($("#Treino_DataFim")).format("YYYY-MM-DD HH:mm:ss"),
        Agrupamentos: listaDeAgrupamentos
    };

    $.ajax({
        type: "post",
        url: `${enderecoAPI}/treino`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(treino),
        success: function (dados) {
            PopUpDeSucesso(dados.msg)
            $('#frmCadastroTreino')[0].reset();
        },
        error: function (dados) {
            Swal.fire(
                `Oops! Há algo de errado`,
                `${dados.responseJSON.msg}`,
                'error',
            );
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
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
        'Erro',
    );
}

/**
 * Retorna na tela um pop-up de alerta na tela do usuário.
 */

function PopUpDeSucesso(mensagem) {
    Swal.fire(
        `Sucesso!`,
        `${mensagem}`,
        'success',
    );
}