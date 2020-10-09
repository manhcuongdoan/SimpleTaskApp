import { SimpleWebAppTemplatePage } from './app.po';

describe('SimpleWebApp App', function() {
  let page: SimpleWebAppTemplatePage;

  beforeEach(() => {
    page = new SimpleWebAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
