//var enderecoSite = "https://localhost:44354";
//var enderecoAPI = "https://localhost:44354/api/v1";

var enderecoSite = "https://localhost:5001";
var enderecoAPI = "https://localhost:5001/api/v1";

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
        type: "Patch",
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
        type: "Patch",
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