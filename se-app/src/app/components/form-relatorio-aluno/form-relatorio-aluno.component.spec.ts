import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormRelatorioAlunoComponent } from './form-relatorio-aluno.component';

describe('FormRelatorioAlunoComponent', () => {
  let component: FormRelatorioAlunoComponent;
  let fixture: ComponentFixture<FormRelatorioAlunoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormRelatorioAlunoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormRelatorioAlunoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
