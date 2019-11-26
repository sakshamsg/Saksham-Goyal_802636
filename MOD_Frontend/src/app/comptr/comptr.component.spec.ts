import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ComptrComponent } from './comptr.component';

describe('ComptrComponent', () => {
  let component: ComptrComponent;
  let fixture: ComponentFixture<ComptrComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ComptrComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ComptrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
