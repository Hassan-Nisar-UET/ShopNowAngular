import { ShopNowAngularTemplatePage } from './app.po';

describe('ShopNowAngular App', function() {
  let page: ShopNowAngularTemplatePage;

  beforeEach(() => {
    page = new ShopNowAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
