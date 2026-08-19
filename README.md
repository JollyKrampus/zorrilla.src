# zorrilla.src

Monolith repository for the Zorrilla project.

## Layout

| Path | Description |
|------|-------------|
| `SinglePageApp/` | ASP.NET Core host for the public site. `SinglePageApp/wwwroot/` is the source of the static site deployed to GitHub Pages. |
| `Zorrilla.Admin/` | Current admin app (Blazor). |
| `legacy/zorrilla.admin/` | The former `zorrilla.admin` repository (Razor Pages version), merged here with full history. Superseded by `Zorrilla.Admin/`. |
| `Zorrilla.Web.sln` | Solution for the public site. |

## GitHub Pages

The live site is served at <https://jollykrampus.github.io/zorrilla.web/> from the separate [`zorrilla.web`](https://github.com/JollyKrampus/zorrilla.web) repository. That repo is kept (archived) solely because the Pages URL is tied to its name; its content and history are consolidated here, and the site source of truth is `SinglePageApp/wwwroot/`.

To publish site changes: unarchive `zorrilla.web`, copy the updated `SinglePageApp/wwwroot/` files into its root, push to its `main` branch, then re-archive it.
