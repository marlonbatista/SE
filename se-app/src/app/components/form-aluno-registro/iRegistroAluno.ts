export interface iRegistroAluno {
    acao: number;
    codigo?: number;
    nome: string;
    sobrenome: string;
    dataNascimento: Date;
    localNascimento: string;
    certidaoNascimento: string;
    cpf: string;
    rg: string;
    endereco: [{
        logradouro: string;
        numero: number;
        bairro: string;
        cidade: string;
        estado: string
    }];
    responsavel: [{
        tipo: number;
        nome: string;
        sobrenome: string;
        cpf: string;
        rg: string;
        telefone: number [];
    }]
}