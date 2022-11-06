IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Enderecos] (
    [Codigo] int NOT NULL IDENTITY,
    [Lougradouro] nvarchar(max) NOT NULL,
    [Numero] int NOT NULL,
    [Complemento] nvarchar(max) NOT NULL,
    [Bairro] nvarchar(max) NOT NULL,
    [Cidade] nvarchar(max) NOT NULL,
    [Estado] nvarchar(max) NOT NULL,
    [CEP] nvarchar(max) NOT NULL,
    [Referencia] nvarchar(max) NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Codigo])
);
GO

CREATE TABLE [Periodos] (
    [Id] int NOT NULL IDENTITY,
    [Turno] nvarchar(max) NOT NULL,
    [Horario] datetime2 NOT NULL,
    CONSTRAINT [PK_Periodos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Series] (
    [Codigo] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Series] PRIMARY KEY ([Codigo])
);
GO

CREATE TABLE [Usuarios] (
    [Codigo] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NOT NULL,
    [Tipo] nvarchar(max) NOT NULL,
    [Senha] nvarchar(max) NOT NULL,
    [Nome] nvarchar(max) NOT NULL,
    [SobreNome] nvarchar(max) NOT NULL,
    [CPF] nvarchar(max) NOT NULL,
    [RG] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Codigo])
);
GO

CREATE TABLE [Turma] (
    [Codigo] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [codPeriodo] int NOT NULL,
    [PeriodoId] int NOT NULL,
    [codSerie] int NOT NULL,
    [SerieCodigo] int NOT NULL,
    [Ano] int NOT NULL,
    CONSTRAINT [PK_Turma] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Turma_Periodos_PeriodoId] FOREIGN KEY ([PeriodoId]) REFERENCES [Periodos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Turma_Series_SerieCodigo] FOREIGN KEY ([SerieCodigo]) REFERENCES [Series] ([Codigo]) ON DELETE CASCADE
);
GO

CREATE TABLE [Alunos] (
    [Registro] int NOT NULL IDENTITY,
    [DataNascimento] datetime2 NOT NULL,
    [localNascimento] nvarchar(max) NOT NULL,
    [CodEndereco] int NOT NULL,
    [TurmaCodigo] int NULL,
    [Nome] nvarchar(max) NOT NULL,
    [SobreNome] nvarchar(max) NOT NULL,
    [CPF] nvarchar(max) NOT NULL,
    [RG] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Alunos] PRIMARY KEY ([Registro]),
    CONSTRAINT [FK_Alunos_Enderecos_CodEndereco] FOREIGN KEY ([CodEndereco]) REFERENCES [Enderecos] ([Codigo]) ON DELETE CASCADE,
    CONSTRAINT [FK_Alunos_Turma_TurmaCodigo] FOREIGN KEY ([TurmaCodigo]) REFERENCES [Turma] ([Codigo])
);
GO

CREATE TABLE [Boletins] (
    [Codigo] int NOT NULL IDENTITY,
    [RegistroAluno] int NOT NULL,
    [AlunoRegistro] int NOT NULL,
    [Faltas] int NOT NULL,
    CONSTRAINT [PK_Boletins] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Boletins_Alunos_AlunoRegistro] FOREIGN KEY ([AlunoRegistro]) REFERENCES [Alunos] ([Registro]) ON DELETE CASCADE
);
GO

CREATE TABLE [Matriculas] (
    [Codigo] int NOT NULL IDENTITY,
    [RegistroAluno] int NOT NULL,
    [AlunoRegistro] int NOT NULL,
    [Numero] int NOT NULL,
    [DataInicio] datetime2 NOT NULL,
    [DataFim] datetime2 NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Matriculas] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Matriculas_Alunos_AlunoRegistro] FOREIGN KEY ([AlunoRegistro]) REFERENCES [Alunos] ([Registro]) ON DELETE CASCADE
);
GO

CREATE TABLE [Responsaveis] (
    [Codigo] int NOT NULL IDENTITY,
    [Contrante] bit NOT NULL,
    [RegistroAluno] int NOT NULL,
    [AlunoRegistro] int NOT NULL,
    [Tipo] nvarchar(max) NOT NULL,
    [Nome] nvarchar(max) NOT NULL,
    [SobreNome] nvarchar(max) NOT NULL,
    [CPF] nvarchar(max) NOT NULL,
    [RG] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Responsaveis] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Responsaveis_Alunos_AlunoRegistro] FOREIGN KEY ([AlunoRegistro]) REFERENCES [Alunos] ([Registro]) ON DELETE CASCADE
);
GO

CREATE TABLE [Disciplinas] (
    [Codigo] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [CargaHoraria] float NOT NULL,
    [BoletimCodigo] int NULL,
    [SerieCodigo] int NULL,
    CONSTRAINT [PK_Disciplinas] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Disciplinas_Boletins_BoletimCodigo] FOREIGN KEY ([BoletimCodigo]) REFERENCES [Boletins] ([Codigo]),
    CONSTRAINT [FK_Disciplinas_Series_SerieCodigo] FOREIGN KEY ([SerieCodigo]) REFERENCES [Series] ([Codigo])
);
GO

CREATE TABLE [Telefones] (
    [Codigo] int NOT NULL IDENTITY,
    [Pais] int NULL,
    [DDD] bigint NOT NULL,
    [Numero] nvarchar(max) NOT NULL,
    [TipoTelefone] int NOT NULL,
    [ResponsavelCodigo] int NULL,
    CONSTRAINT [PK_Telefones] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Telefones_Responsaveis_ResponsavelCodigo] FOREIGN KEY ([ResponsavelCodigo]) REFERENCES [Responsaveis] ([Codigo])
);
GO

CREATE TABLE [Nota] (
    [Codigo] int NOT NULL IDENTITY,
    [Valor] float NOT NULL,
    [CodDisciplina] int NOT NULL,
    [DisciplinaCodigo] int NOT NULL,
    [CodMatricula] int NOT NULL,
    [MatriculaCodigo] int NOT NULL,
    [BoletimCodigo] int NULL,
    CONSTRAINT [PK_Nota] PRIMARY KEY ([Codigo]),
    CONSTRAINT [FK_Nota_Boletins_BoletimCodigo] FOREIGN KEY ([BoletimCodigo]) REFERENCES [Boletins] ([Codigo]),
    CONSTRAINT [FK_Nota_Disciplinas_DisciplinaCodigo] FOREIGN KEY ([DisciplinaCodigo]) REFERENCES [Disciplinas] ([Codigo]) ON DELETE CASCADE,
    CONSTRAINT [FK_Nota_Matriculas_MatriculaCodigo] FOREIGN KEY ([MatriculaCodigo]) REFERENCES [Matriculas] ([Codigo]) ON DELETE CASCADE
);
GO

CREATE TABLE [SerieDisciplina] (
    [CodSerie] int NOT NULL,
    [CodDisciplina] int NOT NULL,
    CONSTRAINT [PK_SerieDisciplina] PRIMARY KEY ([CodDisciplina], [CodSerie]),
    CONSTRAINT [FK_SerieDisciplina_Disciplinas_CodDisciplina] FOREIGN KEY ([CodDisciplina]) REFERENCES [Disciplinas] ([Codigo]) ON DELETE CASCADE,
    CONSTRAINT [FK_SerieDisciplina_Series_CodSerie] FOREIGN KEY ([CodSerie]) REFERENCES [Series] ([Codigo]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Alunos_CodEndereco] ON [Alunos] ([CodEndereco]);
GO

CREATE INDEX [IX_Alunos_TurmaCodigo] ON [Alunos] ([TurmaCodigo]);
GO

CREATE INDEX [IX_Boletins_AlunoRegistro] ON [Boletins] ([AlunoRegistro]);
GO

CREATE INDEX [IX_Disciplinas_BoletimCodigo] ON [Disciplinas] ([BoletimCodigo]);
GO

CREATE INDEX [IX_Disciplinas_SerieCodigo] ON [Disciplinas] ([SerieCodigo]);
GO

CREATE INDEX [IX_Matriculas_AlunoRegistro] ON [Matriculas] ([AlunoRegistro]);
GO

CREATE INDEX [IX_Nota_BoletimCodigo] ON [Nota] ([BoletimCodigo]);
GO

CREATE INDEX [IX_Nota_DisciplinaCodigo] ON [Nota] ([DisciplinaCodigo]);
GO

CREATE INDEX [IX_Nota_MatriculaCodigo] ON [Nota] ([MatriculaCodigo]);
GO

CREATE INDEX [IX_Responsaveis_AlunoRegistro] ON [Responsaveis] ([AlunoRegistro]);
GO

CREATE INDEX [IX_SerieDisciplina_CodSerie] ON [SerieDisciplina] ([CodSerie]);
GO

CREATE INDEX [IX_Telefones_ResponsavelCodigo] ON [Telefones] ([ResponsavelCodigo]);
GO

CREATE INDEX [IX_Turma_PeriodoId] ON [Turma] ([PeriodoId]);
GO

CREATE INDEX [IX_Turma_SerieCodigo] ON [Turma] ([SerieCodigo]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221020125917_Inicial-v1', N'6.0.10');
GO

COMMIT;
GO

