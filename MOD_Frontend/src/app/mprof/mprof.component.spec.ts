import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MprofComponent } from './mprof.component';

describe('MprofComponent', () => {
  let component: MprofComponent;
  let fixture: ComponentFixture<MprofComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MprofComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MprofComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
