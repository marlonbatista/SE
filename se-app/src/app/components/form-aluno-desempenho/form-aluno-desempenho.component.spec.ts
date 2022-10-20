import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormAlunoDesempenhoComponent } from './form-aluno-desempenho.component';

describe('FormAlunoDesempenhoComponent', () => {
  let component: FormAlunoDesempenhoComponent;
  let fixture: ComponentFixture<FormAlunoDesempenhoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormAlunoDesempenhoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormAlunoDesempenhoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
