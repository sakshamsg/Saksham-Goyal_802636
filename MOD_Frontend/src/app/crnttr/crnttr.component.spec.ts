import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrnttrComponent } from './crnttr.component';

describe('CrnttrComponent', () => {
  let component: CrnttrComponent;
  let fixture: ComponentFixture<CrnttrComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrnttrComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrnttrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
