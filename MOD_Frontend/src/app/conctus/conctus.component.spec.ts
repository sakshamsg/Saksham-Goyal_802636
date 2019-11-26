import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConctusComponent } from './conctus.component';

describe('ConctusComponent', () => {
  let component: ConctusComponent;
  let fixture: ComponentFixture<ConctusComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConctusComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConctusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
