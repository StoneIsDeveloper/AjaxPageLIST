# AjaxPageLIST

依赖的文件

js:

jquery.unobtrusive-ajax.js

jquery.validate.unobtrusive.min.js

reference:

PagedList
PageList.Mvc

要实现Ajax分页，必须要有 jquery.unobtrusive-ajax.js

先看一下方法的参数 参数最多3个，

PagedListPager(this System.Web.Mvc.HtmlHelper html, 

    IPagedList list,
    
    Func<int, string> generatePageUrl, 
    
    PagedListRenderOptions options);
    
    
EnableUnobtrusiveAjaxReplacing 有3个方法重载，这里使用带两种参数的类型，

    EnableUnobtrusiveAjaxReplacing(PagedListRenderOptions options, AjaxOptions ajaxOptions);
    
这样的话,既可以启用Ajax方式，同时也可以配置 options.

但是这里还是有一个问题，在AjaxOptions中配置Url时，不能获取page,页码，

所以这里另外用一段js来把a标签的href赋值给data-ajax-url.

因为 unobtrusive-ajax 本身就是非侵入式的思想，这样做的话，

反而违背了这种思想，暂时还没有想到更好的办法，后面发现如果有更好的方法，在继续更新优化。





